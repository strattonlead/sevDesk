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
        private readonly ISevDeskService _sevDeskService;

        public UnitTest1()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSevDeskService(options => options.UseToken("f6275bb005abe83ec3d9a442cac2c367"));
            _scope = services.BuildServiceProvider().CreateScope();
            _serviceProvider = _scope.ServiceProvider;
            _sevDeskService = _serviceProvider.GetRequiredService<ISevDeskService>();
        }

        [Fact]
        public void Test1()
        {
            var countries = _sevDeskService.GetListAsync<StaticCountry>().Result.Result;
            var contacts = _sevDeskService.GetListAsync<Contact>().Result.Result;
            var contact = contacts.FirstOrDefault();//_sevDeskService.GetAsync<Contact>("1").Result.Result;
            if (contact == null)
            {
                contact = new Contact()
                {
                    Name = "Harald Müller"
                };
            }

            var contactPeople = _sevDeskService.GetListAsync<SevUser>().Result.Result;
            var contactPerson = contactPeople.FirstOrDefault();

            var invoiceNumber = _sevDeskService.FactoryGetNextInvoiceNumberAsync().Result.Result;

            var invoice = new Invoice()
            {
                InvoiceNumber = invoiceNumber,
                Contact = contact,
                ContactPerson = contactPerson,
                InvoiceDate = DateTime.Now.Date,
                Header = $"Rechnung {invoiceNumber}",
                TimeToPay = 7,
                Discount = 0,
                address = "Arndt Bieberstein\nIm Neuneck 2/1\n78609 Tuningen",
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

            var result = _sevDeskService.FactorySaveInvoiceAsync(invoice, invoicePos).Result;
            invoice = result.Invoice;

            var pdf = _sevDeskService.GetPdfAsync(invoice).Result;
        }
    }
}