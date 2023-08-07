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
        public void CreateInvoiceWithExistingCustomerTest()
        {
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
                Contact = new SevDeskContact()
                {
                    Id = "64658688"
                },
                ContactPerson = contactPerson,
                CreateLineItems = new List<CreateLineItemRequest>()
                {
                    new CreateLineItemRequest()
                    {
                        Quantity = 1,
                        PriceNet = 99,
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

        [Fact]
        public void CreateInvoiceWithNewCustomerTest()
        {
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
                CreateContact = new CreateContactRequest()
                {
                    CompanyName = "Löffel GmbH",
                    FirstName = "Simon",
                    LastName = "Löffler",
                    Title = "M.Sc",
                    ValueAddedTaxId = "DE326904432",
                    Description = "Ein starker Mitarbeiter"
                },
                ContactPerson = contactPerson,
                CreateLineItems = new List<CreateLineItemRequest>()
                {
                    new CreateLineItemRequest()
                    {
                        Quantity = 1,
                        PriceNet = 99,
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

        [Fact]
        public void CRUDCustomerTest()
        {
            var request = new CreateContactRequest()
            {
                CompanyName = "Neu erstellt",
                FirstName = "Vorname",
                LastName = "Nachname",
                Title = "M.Sc",
                ValueAddedTaxId = "DE326904432",
                Description = "Neu erstellt"
            };

            var customer = _sevDeskService.CreateContactAsync(request).Result;

            var updateRequest = new UpdateContactRequest(customer);
            updateRequest.FirstName = "Neuer Name";
            updateRequest.LastName = "Neuer Nachname";
            customer = _sevDeskService.UpdateContactAsync(updateRequest).Result;

            Assert.Equal(updateRequest.FirstName, customer.FirstName);
            Assert.Equal(updateRequest.LastName, customer.LastName);

            customer = _sevDeskService.GetContactAsync(customer.Id).Result;

            Assert.Equal(updateRequest.FirstName, customer.FirstName);
            Assert.Equal(updateRequest.LastName, customer.LastName);

            var success = _sevDeskService.DeleteContactAsync(customer.Id).Result;
            Assert.True(success);

            customer = _sevDeskService.GetContactAsync(customer.Id).Result;
            Assert.Null(customer);
        }

        [Fact]
        public void CRUDOrderTest()
        {
            var createCustomer = new CreateContactRequest()
            {
                CompanyName = "Neu erstellt",
                FirstName = "Vorname",
                LastName = "Nachname",
                Title = "M.Sc",
                ValueAddedTaxId = "DE326904432",
                Description = "Neu erstellt"
            };

            var customer = _sevDeskService.CreateContactAsync(createCustomer).Result;
            var contactPerson = _sevDeskService.GetAnyContactPerson().Result; // "777966"

            var request = new CreateOrderRequest()
            {
                Address = "Arndt Bieberstein\nIm Neuneck 2/1\n78609 Tuningen",
                Contact = customer,
                ContactPerson = contactPerson,
                //Currency = "EUR",
                CustomerInternalNote = "CustomerInternalNote",
                //FootText = "FootText",
                //HeadText = "HeadText",
                Header = "Header",
                OrderDate = DateTime.Now.Date,
                OrderStatus = OrderStatus.Accepted,
                OrderType = OrderType.Order,
                SendDate = DateTime.Now.Date,
                ShowNet = true,
                TaxRate = 19,
                //TaxText = "TaxText",
                Version = 0,
                CreateOrderLineItems = new List<CreateOrderLineItemRequest>()
                {
                    new CreateOrderLineItemRequest()
                    {
                        Name = "Name",
                        TaxRate = 19,
                        Price = 100,
                        Quantity = 1,
                        Text = "Text",
                        UnityType = UnityTypes.FLAT_RATE.Id
                    }
                }
            };

            var order = _sevDeskService.CreateOrderAsync(request).Result;

            var updateRequest = new UpdateOrderRequest()
            {
                Id = order.Id,
                Status = OrderStatus.RejectedOrCancelled
            };
            var updatedOrder = _sevDeskService.UpdateOrderAsync(updateRequest).Result;

            Assert.Equal(OrderStatus.Accepted, order.OrderStatus);
            Assert.Equal(OrderStatus.RejectedOrCancelled, updatedOrder.OrderStatus);

            _sevDeskService.DeleteContactAsync(customer.Id).Wait();
        }

        [Fact]
        public void OrderNumberTest()
        {
            var orderNumber1 = _sevDeskService.GetNextOrderNumberAsync(OrderType.Order).Result;
            var orderNumber2 = _sevDeskService.GetNextOrderNumberAsync(OrderType.Order).Result;

            Assert.Equal(orderNumber2, orderNumber1);
        }

        [Fact]
        public void SupplierTest()
        {
            var contact = _sevDeskService.CreateContactAsync(new CreateContactRequest()
            {
                CompanyName = "TEST GmbH",
                ContactType = ContactTypes.Supplier,
                FirstName = "SupplierTest",
                LastName = "SupplierTest"
            }).Result;

            Assert.Equal(ContactTypes.Supplier, contact.ContactType);
        }
    }
}