using Microsoft.Extensions.DependencyInjection;
using sevDesk.Api;
using SevDeskClient;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace sevDesk.Tests
{
    public class UnitTest1
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _scope;
        private readonly ISevDeskClient _sevDeskClient;
        private readonly ISevDeskService _sevDeskService;

        public UnitTest1()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSevDeskService(options => options.UseToken("f6275bb005abe83ec3d9a442cac2c367").UseSourceCountry("de"));
            _scope = services.BuildServiceProvider().CreateScope();
            _serviceProvider = _scope.ServiceProvider;
            _sevDeskClient = _serviceProvider.GetRequiredService<ISevDeskClient>();
            _sevDeskService = _serviceProvider.GetRequiredService<ISevDeskService>();
        }

        [Fact]
        public void TestClient()
        {
            var countries = _sevDeskClient.GetListAsync<StaticCountry>().Result.Result;
            var contacts = _sevDeskClient.GetListAsync<Contact>().Result.Result;
            var contact = contacts.FirstOrDefault();//_sevDeskService.GetAsync<Contact>("1").Result.Result;
            if (contact == null)
            {
                contact = new Contact()
                {
                    Name = "Harald Müller"
                };
            }

            var contactPeople = _sevDeskClient.GetListAsync<SevUser>().Result.Result;
            var contactPerson = contactPeople.FirstOrDefault();

            var invoiceNumber = _sevDeskClient.FactoryGetNextInvoiceNumberAsync().Result.Result;

            var invoice = new Invoice()
            {
                InvoiceNumber = invoiceNumber,
                Contact = contact,
                ContactPerson = contactPerson,
                InvoiceDate = DateTime.Now.Date,
                Header = $"Rechnung {invoiceNumber}",
                TimeToPay = 7,
                Discount = 0,
                Address = "Arndt Bieberstein\nIm Neuneck 2/1\n78609 Tuningen",
                AddressCountry = countries.FirstOrDefault(x => x.Code == "de"),
                PayDate = null,
                DeliveryDate = DateTime.Now.Date,
                Status = "100",
                SmallSettlement = 0,
                TaxRate = 19,
                TaxText = "Umsatzsteuer 19%",
                TaxType = "default",
                SendDate = DateTime.Now.Date,
                InvoiceType = "RE",
                Currency = "EUR",
                ShowNet = 1,
                SendType = "VPR",
                CreateUser = contactPerson
            };

            var invoicePos = new List<InvoicePos>()
            {
                new InvoicePos()
                {
                    Quantity = 1,
                    PriceNet = 100,
                    Name = "Position 1",
                    PositionNumber = 0,
                    Text = "Beschreibung",
                    Discount = 0,
                    TaxRate = 19,
                },
                new InvoicePos()
                {
                    Quantity = 1,
                    PriceNet = 120,
                    Name = "Position 2",
                    PositionNumber = 1,
                    Text = "Beschreibung 2",
                    Discount = 0,
                    TaxRate = 19,
                }
            };

            var result = _sevDeskClient.FactorySaveInvoiceAsync(invoice, invoicePos).Result;
            invoice = result.Invoice;

            var pdf = _sevDeskClient.GetPdfAsync(invoice).Result;
        }

        [Fact]
        public void TestService()
        {
            var aaaaa = _sevDeskService.GetUnitsAsync().Result;
            var germany = _sevDeskService.GetCountryAsync("de").Result;
            var contactPerson = _sevDeskService.GetAnyContactPerson().Result; // "777966"

            var createRequest = new CreateInvoiceRequest()
            {
                AddressName = "Simon Löffler",
                AddressStreet = "Bahnhofstraße",
                AddressHouseNumber = "8/1",
                AddressPostalCode = "78048",
                AddressCity = "Villingen",
                AddressCountry = germany,
                InvoiceDate = DateTime.Now.Date,
                DeliveryDate = DateTime.Now.Date,
                CreatePdf = true,
                TimeToPay = 30,
                CreateCustomer = new CreateCustomerRequest()
                {
                    Name = "Löffel GmbH",
                    Surename = "Simon",
                    Familyname = "Löffler",
                    Titel = "M.Sc",
                    VatNumber = "DE326904432",
                    Description = "Ein starker Mitarbeiter"
                },
                ContactPerson = contactPerson,
                LineItems = new List<CreateLineItemRequest>()
                {
                    new CreateLineItemRequest()
                    {
                        Quantity = 1,
                        PriceNet = 100,
                        Name = "Position 1",
                        Text = "Normal mit 19% puaschal",
                        TaxRate = 19,
                        UnityType = UnityTypes.FLAT_RATE.Id
                    },
                    new CreateLineItemRequest()
                    {
                        Quantity = 1,
                        PriceNet = 100,
                        Name = "Position 2",
                        Text = "Ohne Steuer in Stunden",
                        TaxRate = 0,
                        UnityType = UnityTypes.HOURS.Id
                    },
                     new CreateLineItemRequest()
                    {
                        Quantity = 1,
                        PriceNet = 100,
                        Name = "Position 3",
                        Text = "Steuer automatisch berechnen in Stück",
                        UnityType = UnityTypes.PIECES.Id
                    }
                }
            };

            var result = _sevDeskService.CreateInvoiceAsync(createRequest).Result;

            Assert.NotNull(result.PdfStream);
        }
    }
}