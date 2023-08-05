using Newtonsoft.Json;
using SevDeskClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace sevDesk.Api
{
    public class SevDeskService : ISevDeskService
    {
        #region Properties

        private readonly SevDeskServiceOptions _options;
        private readonly ISevDeskClient _sevDeskClient;
        private static List<StaticCountry> _countryCache;
        private static List<Unity> _unityCache;

        private List<string> _euCountries = new List<string> { "at", "be", "bg", "cy", "cz", "de", "dk", "ee", "es", "fi", "fr", "gr", "hr", "hu", "ie", "it", "lt", "lu", "lv", "mt", "nl", "pl", "pt", "ro", "se", "si", "sk" };
        private static SevDeskCountry _sourceCountry;

        #endregion

        #region Constructor

        public SevDeskService(SevDeskServiceOptions options, ISevDeskClient sevDeskClient)
        {
            _options = options;
            _sevDeskClient = sevDeskClient;
        }

        #endregion

        #region Converter

        private StaticCountry _get(SevDeskCountry country) => _countryCache?.FirstOrDefault(x => x.Id == country.Id);


        #endregion

        #region Mapped

        public async Task<SevDeskCountry> GetCountryAsync(string code, CancellationToken cancellationToken = default)
        {
            var countries = await GetCountriesAsync(cancellationToken);
            return countries.FirstOrDefault(x => x.Code == code);
        }

        public async Task<List<SevDeskCountry>> GetCountriesAsync(CancellationToken cancellationToken = default)
        {
            if (_countryCache != null)
            {
                return _countryCache.Convert();
            }

            var countryResult = await _sevDeskClient.GetListAsync<StaticCountry>(0, null, null, true, true, cancellationToken);
            if (!countryResult.Success)
            {
                return null;
            }

            _countryCache = countryResult.Result;
            var sourceCountry = _countryCache.FirstOrDefault(x => x.Code == _options.SourceCountry);
            _sourceCountry = sourceCountry.Convert();
            return _countryCache.Convert();
        }


        /*
         * Supplier (ID: 2)
         * Customer (ID: 3)
         * Partner (ID: 4)
         * Prospect Customer (ID: 28)
         */

        public async Task<SevDeskCustomer> CreateCustomerAsync(CreateCustomerRequest createCustomerRequest, CancellationToken cancellationToken = default)
        {
            var getCustomerNumberResult = await _sevDeskClient.FactoryGetNextCustomerNumberAsync(cancellationToken);
            if (!getCustomerNumberResult.Success)
            {
                return null;
            }

            var contact = createCustomerRequest.Convert();
            contact.Category = new Category()
            {
                Id = "3"
            };
            contact.CustomerNumber = getCustomerNumberResult.Result;

            var postResult = await _sevDeskClient.CreateContact(contact, cancellationToken);
            if (!postResult.Success)
            {
                return null;
            }

            return postResult.Result.Convert();
        }

        public async Task<SevDeskCustomer> UpdateCustomerAsync(UpdateCustomerRequest updateCustomerRequest, CancellationToken cancellationToken = default)
        {
            var contact = updateCustomerRequest.Convert();
            contact.Category = new Category()
            {
                Id = "3"
            };

            var postResult = await _sevDeskClient.UpdateAsync(contact, cancellationToken);
            if (!postResult.Success)
            {
                return null;
            }

            return postResult.Result.Convert();
        }

        public async Task<bool> DeleteCustomerAsync(string id, CancellationToken cancellationToken = default)
        {
            var deleteResult = await _sevDeskClient.DeleteAsync<Contact>(id, cancellationToken);
            return deleteResult.Success;
        }

        public async Task<SevDeskCustomer> GetCustomerAsync(string id, CancellationToken cancellationToken = default)
        {
            var getResult = await _sevDeskClient.GetAsync<Contact>(id, null, cancellationToken);
            if (!getResult.Success)
            {
                return null;
            }

            return getResult.Result.Convert();
        }


        public async Task<SevDeskUser> GetContactPerson(string id, CancellationToken cancellationToken = default)
        {
            var getListResult = await _sevDeskClient.GetListAsync<SevUser>(0, null, null, true, true, cancellationToken);
            if (!getListResult.Success)
            {
                return null;
            }

            return getListResult.Result?.FirstOrDefault(x => x.Id == id)?.Convert();
        }

        public async Task<SevDeskUser> GetAnyContactPerson(CancellationToken cancellationToken = default)
        {
            var getListResult = await _sevDeskClient.GetListAsync<SevUser>(0, null, null, true, true, cancellationToken);
            if (!getListResult.Success)
            {
                return null;
            }

            return getListResult.Result?.FirstOrDefault()?.Convert();
        }

        /// <summary>
        /// default - Umsatzsteuer ausweisen
        /// eu - Steuerfreie innergemeinschaftliche Lieferung(Europäische Union)
        /// noteu - Steuerschuldnerschaft des Leistungsempfängers(außerhalb EU, z.B.Schweiz)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns> </returns>
        public string GetTaxType(SevDeskCountry source, SevDeskCountry destination)
        {
            if (source.Code == destination.Code)
            {
                return "default";
            }

            if (_euCountries.Contains(destination.Code))
            {
                return "eu";
            }

            return "noteu";
        }

        public int GetDefaultTaxRate(string taxType)
        {
            switch (taxType)
            {
                case "default":
                    return 19;
                default:
                    return 0;
            }
        }

        public async Task<List<Unity>> GetUnitsAsync(CancellationToken cancellationToken = default)
        {
            if (_unityCache != null)
            {
                return _unityCache;
            }

            var getListResult = await _sevDeskClient.GetListAsync<Unity>(0, null, null, true, true, cancellationToken);
            if (!getListResult.Success)
            {
                return null;
            }

            _unityCache = getListResult.Result;
            return _unityCache;
        }

        public async Task<SevDeskInvoice> CreateInvoiceAsync(CreateInvoiceRequest request, CancellationToken cancellationToken = default)
        {
            if (request.TimeToPay < 0)
            {
                request.TimeToPay = 0;
            }

            if (string.IsNullOrWhiteSpace(request.AddressName))
            {
                throw new ArgumentException("AddressName is null");
            }

            if (string.IsNullOrWhiteSpace(request.AddressStreet))
            {
                throw new ArgumentException("AddressStreet is null");
            }

            if (string.IsNullOrWhiteSpace(request.AddressHouseNumber))
            {
                throw new ArgumentException("AddressHouseNumber is null");
            }

            if (string.IsNullOrWhiteSpace(request.AddressPostalCode))
            {
                throw new ArgumentException("AddressPostalCode is null");
            }

            if (string.IsNullOrWhiteSpace(request.AddressCity))
            {
                throw new ArgumentException("AddressCity is null");
            }

            if (request.CreateLineItems == null)
            {
                throw new ArgumentNullException("LineItems is null");
            }

            if (!request.CreateLineItems.Any())
            {
                throw new ArgumentException("No line items");
            }

            if (request.AddressCountry == null)
            {
                throw new ArgumentNullException("Country is null");
            }

            var addressCountry = _get(request.AddressCountry);
            if (addressCountry == null)
            {
                throw new ArgumentException($"Country {request.AddressCountry.Name} ({request.AddressCountry.Id}) not found");
            }

            var taxType = GetTaxType(_sourceCountry, request.AddressCountry);
            if (string.IsNullOrWhiteSpace(taxType))
            {
                throw new Exception("TaxType can not be determined.");
            }

            var taxRate = GetDefaultTaxRate(taxType);

            if (request.Customer != null && request.CreateCustomer != null)
            {
                throw new ArgumentException("Ambingious customer.");
            }

            if (request.Customer == null && request.CreateCustomer == null)
            {
                throw new ArgumentException("Customer and CreateCustomer is null");
            }

            var customer = request.Customer;
            Contact contact = null;
            if (request.Customer != null)
            {
                contact = request.Customer.Convert();
            }

            if (request.CreateCustomer != null)
            {
                customer = await CreateCustomerAsync(request.CreateCustomer, cancellationToken);
                contact = customer.Convert();
            }

            if (request.ContactPerson == null)
            {
                throw new ArgumentNullException("ContactPerson is null");
            }

            var contactPerson = request.ContactPerson.Convert();
            var createUser = request.CreatedBy?.Convert() ?? contactPerson;

            var getInvoiceNumberResult = await _sevDeskClient.FactoryGetNextInvoiceNumberAsync("RE", false, cancellationToken);
            if (!getInvoiceNumberResult.Success)
            {
                throw new Exception("Unable to get next invoice number.");
            }
            var invoiceNumber = getInvoiceNumberResult.Result;

            var invoice = new Invoice()
            {
                InvoiceNumber = invoiceNumber,
                Contact = contact,
                ContactPerson = contactPerson,
                InvoiceDate = request.InvoiceDate.Date,
                Header = $"Rechnung {invoiceNumber}",
                TimeToPay = request.TimeToPay,
                Address = $"{request.AddressName}\n{request.AddressStreet} {request.AddressHouseNumber}\n{request.AddressPostalCode} {request.AddressCity}",// "Arndt Bieberstein\nIm Neuneck 2/1\n78609 Tuningen",
                AddressCountry = addressCountry,
                DeliveryDate = request.DeliveryDate.Date,
                Status = "200", // 100 = draft, 200 = geliefert, 1000 = bezahlt
                TaxRate = request.TaxRate ?? taxRate,
                TaxText = $"Umsatzsteuer {request.TaxRate}%",
                TaxType = taxType,
                SendDate = DateTime.Now.Date,
                InvoiceType = "RE",
                Currency = "EUR",
                ShowNet = 1,
                SendType = request.CreatePdf ? "VPDF" : "VPR",
                CreateUser = createUser
            };

            if (taxType != "default")
            {
                invoice.FootText = "Umsatzsteuerschuldnerschaft des Leistungsempfängers";
            }

            var invoicePos = new List<InvoicePos>();
            var posNumber = 0;
            foreach (var lineItem in request.CreateLineItems)
            {
                var pos = lineItem.Convert();
                pos.PositionNumber = posNumber++;
                invoicePos.Add(pos);
            }

            var factoryInvoiceResult = await _sevDeskClient.FactorySaveInvoiceAsync(invoice, invoicePos);
            invoice = factoryInvoiceResult.Invoice;
            invoicePos = factoryInvoiceResult.InvoicePos;

            var result = new SevDeskInvoice()
            {
                Id = invoice.Id,
                InvoiceNumber = invoice.InvoiceNumber,
                AddressCountry = request.AddressCountry,
                Address = invoice.Address,
                ContactPerson = request.ContactPerson,
                Customer = customer,
                DeliveryDate = invoice.DeliveryDate,
                InvoiceDate = invoice.InvoiceDate.Value,
                TaxRate = invoice.TaxRate,
                TimeToPay = invoice.TimeToPay,
                NetValue = invoice.SumNet,
                GrossValue = invoice.SumGross,
                TaxValue = invoice.SumTax,
                LineItems = invoicePos.Convert()
            };

            if (request.CreatePdf)
            {
                var streamResult = await _sevDeskClient.GetPdfAsync(invoice);
                if (streamResult.Success)
                {
                    result.PdfStream = streamResult.Stream;
                }
            }

            return result;
        }

        /// <summary>
        /// Angebot, Auftrag und Lieferschein 
        /// </summary>
        /// <returns></returns>
        public async Task<SevDeskOrder> CreateOrderAsync(CreateOrderRequest request, CancellationToken cancellationToken = default)
        {
            var order = new Order()
            {
                Address = request.Address,
                Contact = request.Customer.Convert(),
                ContactPerson = request.ContactPerson.Convert(),
                Currency = request.Currency,
                CustomerInternalNote = request.CustomerInternalNote,
                //DeliveryTerms = 0,
                FootText = request.FootText,
                Header = request.Header,
                HeadText = request.HeadText,
                OrderDate = request.OrderDate,
                OrderNumber = request.OrderNumber,
                OrderType = request.OrderType.Convert(),
                Origin = request.Origin,
                //PaymentTerms = 0,
                SendDate = request.SendDate,
                ShowNet = request.ShowNet,
                SendType = request.SendType,
                SmallSettlement = false,
                Status = request.OrderStatus.Convert(),
                TaxRate = request.TaxRate,
                //TaxSet = "",
                TaxText = request.TaxText,
                TaxType = request.TaxType,
                //TypeOrigin = "",
                Version = request.Version
            };

            var orderPos = new List<OrderPos>();
            var posNumber = 0;
            foreach (var lineItem in request.CreateOrderLineItems)
            {
                var pos = lineItem.Convert();
                pos.PositionNumber = posNumber++;
                //pos.Order = new Order();
                orderPos.Add(pos);
            }

            var factoryOrderResult = await _sevDeskClient.FactorySaveOrderAsync(order, orderPos, cancellationToken);
            order = factoryOrderResult.Order;
            orderPos = factoryOrderResult.OrderPos;
            var result = order.Convert(orderPos);

            if (request.CreatePdf)
            {
                var streamResult = await _sevDeskClient.GetPdfAsync(order);
                if (streamResult.Success)
                {
                    result.PdfStream = streamResult.Stream;
                }
            }

            return result;
        }

        public async Task<SevDeskOrder> UpdateOrderAsync(UpdateOrderRequest updateOrderRequest, CancellationToken cancellationToken = default)
        {
            var updateResult = await _sevDeskClient.UpdateAsync<Order>(updateOrderRequest.Id, updateOrderRequest, cancellationToken);
            if (!updateResult.Success)
            {
                return null;
            }

            return updateResult.Result.Convert();
        }


        #endregion
    }


    public class UpdateOrderRequest
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore)]
        public OrderStatus? Status { get; set; }

        [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SendDate { get; set; }
    }

    public class CreateOrderRequest : SevDeskOrder
    {
        public bool CreatePdf { get; set; }

        public List<CreateOrderLineItemRequest> CreateOrderLineItems { get; set; } = new List<CreateOrderLineItemRequest>();
    }

    public class SevDeskOrder
    {
        public int Id { get; set; }
#warning TODO als result machen
        public List<SevDeskOrderLineItem> LineItems { get; set; }
        public string TaxType { get; set; }
        public string Currency { get; set; } = "EUR";
        public string CustomerInternalNote { get; set; }
        public int Version { get; set; }
        public string TaxText { get; set; } = "zzgl. Umsatzsteuer 19%";
        public int TaxRate { get; set; }
        public OrderType OrderType { get; set; }
        public int Origin { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public SevDeskUser ContactPerson { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public string SendType { get; set; } = "VPR";
        public string OrderNumber { get; set; }
        public SevDeskCustomer Customer { get; set; }
        public string Header { get; set; }
        public string HeadText { get; set; }
        public string FootText { get; set; }
        public bool ShowNet { get; set; }
        public DateTime? SendDate { get; set; }
        public Stream PdfStream { get; set; }
    }

    public class CreateOrderLineItemRequest : SevDeskOrderLineItem { }

    public class SevDeskOrderLineItem
    {
        public int Id { get; set; }
        public decimal TaxRate { get; set; }
        public string UnityType { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public enum OrderType
    {
        /// <summary>
        /// Angebot | AN
        /// </summary>
        Proposal = 0,

        /// <summary>
        /// Angebot | AB
        /// </summary>
        Order = 1,

        /// <summary>
        /// Lieferschein | LI
        /// </summary>
        DeliveryNote = 2
    }

    public enum OrderStatus
    {
        /// <summary>
        /// The order is still a draft. 
        /// It has not been sent to the end-customer and can still be changed.
        /// </summary>
        Draft = 100,

        /// <summary>
        /// The order has been sent to the end-customer.
        /// </summary>
        Delivered = 200,

        /// <summary>
        /// The order has been rejected by the end-customer.
        /// </summary>
        RejectedOrCancelled = 300,

        /// <summary>
        /// The order has been accepted by the end-customer.
        /// </summary>
        Accepted = 500,

        /// <summary>
        /// An invoice for parts of the order (but not the full order) has been created.
        /// </summary>
        PartiallyCalculated = 750,

        /// <summary>
        /// The order has been calculated.
        /// One or more invoices have been created covering the whole order.
        /// </summary>
        Calculated = 1000
    }



    internal static class ConverterExtensions
    {
        internal static Func<StaticCountry, SevDeskCountry> _countryConverter = x => new SevDeskCountry() { Id = x.Id, Name = x.Name, Code = x.Code };
        internal static Func<InvoicePos, SevDeskLineItem> _lineItemConverter = x => new SevDeskLineItem() { Id = x.Id, Name = x.Name, PriceNet = x.PriceNet, Quantity = x.Quantity, TaxRate = x.TaxRate, Text = x.Text, UnityType = x.unity?.Id };
        internal static Func<OrderPos, SevDeskOrderLineItem> _orderLineItemConverter = x => new SevDeskOrderLineItem() { /*Id = x.Id,*/ Discount = x.Discount, Name = x.Name, Price = x.Price, Quantity = x.Quantity, TaxRate = x.TaxRate, Text = x.Text, UnityType = x.Unity?.Id };
        internal static List<SevDeskCountry> Convert(this IEnumerable<StaticCountry> countries) => countries?.Select(_countryConverter)?.ToList();
        internal static List<SevDeskLineItem> Convert(this IEnumerable<InvoicePos> lineItems) => lineItems?.Select(_lineItemConverter)?.ToList();
        internal static List<SevDeskOrderLineItem> Convert(this IEnumerable<OrderPos> lineItems) => lineItems?.Select(_orderLineItemConverter)?.ToList();

        internal static Contact Convert(this CreateCustomerRequest customer) => new Contact()
        {
            Status = "1000",
            Name = customer.CompanyName,
            VatNumber = customer.ValueAddedTaxId,
            Familyname = customer.LastName,
            Surename = customer.FirstName,
            Titel = customer.Title,
            Description = customer.Description
        };

        internal static Contact Convert(this SevDeskCustomer customer)
        {
            var result = ((CreateCustomerRequest)customer).Convert();
            result.Id = customer.Id;
            return result;
        }

        internal static SevDeskCustomer Convert(this Contact contact) => new SevDeskCustomer() { Id = contact.Id, CompanyName = contact.Name, ValueAddedTaxId = contact.VatNumber, FirstName = contact.Surename, LastName = contact.Familyname, Title = contact.Titel, Description = contact.Description };
        internal static SevUser Convert(this SevDeskUser user) => new SevUser() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Fullname = user.Fullname, LastName = user.LastName, Username = user.Username };
        internal static SevDeskUser Convert(this SevUser user) => new SevDeskUser() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Fullname = user.Fullname, LastName = user.LastName, Username = user.Username };
        internal static SevDeskCountry Convert(this StaticCountry country) => _countryConverter(country);
        internal static InvoicePos Convert(this CreateLineItemRequest lineItem) => new InvoicePos() { Name = lineItem.Name, PriceNet = lineItem.PriceNet, Quantity = lineItem.Quantity, Text = lineItem.Text, unity = UnityTypes.GetUnity(lineItem.UnityType) };
        internal static OrderPos Convert(this CreateOrderLineItemRequest lineItem) => new OrderPos()
        {
            Name = lineItem.Name,
            Price = lineItem.Price,
            Quantity = lineItem.Quantity,
            Text = lineItem.Text,
            Unity = UnityTypes.GetUnity(lineItem.UnityType),
            Discount = lineItem.Discount,
            TaxRate = lineItem.TaxRate
        };

        internal static string Convert(this OrderType orderType)
        {
            switch (orderType)
            {
                case OrderType.Proposal:
                    return "AN";
                case OrderType.Order:
                    return "AB";
                case OrderType.DeliveryNote:
                    return "LI";
                default:
                    return null;
            }
        }

        internal static OrderType GetOrderType(string orderType)
        {
            switch (orderType)
            {
                case "AN":
                    return OrderType.Proposal;
                case "AB":
                    return OrderType.Order;
                case "LI":
                    return OrderType.DeliveryNote;
                default:
                    return OrderType.Proposal;
            }
        }

        internal static int Convert(this OrderStatus orderStatus) => (int)orderStatus;

        internal static SevDeskOrder Convert(this Order order, List<OrderPos> orderPos = null) => new SevDeskOrder()
        {
            Id = int.Parse(order.Id),
            Address = order.Address,
            Customer = order.Contact.Convert(),
            ContactPerson = order.ContactPerson.Convert(),
            Currency = order.Currency,
            CustomerInternalNote = order.CustomerInternalNote,
            FootText = order.FootText,
            Header = order.Header,
            HeadText = order.HeadText,
            OrderDate = order.OrderDate,
            OrderNumber = order.OrderNumber,
            OrderStatus = (OrderStatus)order.Status,
            OrderType = GetOrderType(order.OrderType),
            Origin = order.Origin,
            SendDate = order.SendDate,
            SendType = order.SendType,
            ShowNet = order.ShowNet,
            TaxRate = order.TaxRate,
            TaxText = order.TaxText,
            TaxType = order.TaxType,
            LineItems = orderPos?.Convert()
        };
    }
}