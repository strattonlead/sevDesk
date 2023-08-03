using SevDeskClient;
using System;
using System.Collections.Generic;
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

            if (request.LineItems == null)
            {
                throw new ArgumentNullException("LineItems is null");
            }

            if (!request.LineItems.Any())
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
            foreach (var lineItem in request.LineItems)
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


        #endregion
    }

    internal static class ConverterExtensions
    {
        internal static Func<StaticCountry, SevDeskCountry> _countryConverter = x => new SevDeskCountry() { Id = x.Id, Name = x.Name, Code = x.Code };
        internal static Func<InvoicePos, SevDeskLineItem> _lineItemConverter = x => new SevDeskLineItem() { Id = x.Id, Name = x.Name, PriceNet = x.PriceNet, Quantity = x.Quantity, TaxRate = x.TaxRate, Text = x.Text, UnityType = x.unity?.Id };
        internal static List<SevDeskCountry> Convert(this IEnumerable<StaticCountry> countries) => countries?.Select(_countryConverter)?.ToList();
        internal static List<SevDeskLineItem> Convert(this IEnumerable<InvoicePos> lineItems) => lineItems?.Select(_lineItemConverter)?.ToList();

        internal static Contact Convert(this CreateCustomerRequest customer) => new Contact()
        {
            Status = "1000",
            Name = customer.Name,
            VatNumber = customer.VatNumber,
            Familyname = customer.Familyname,
            Surename = customer.Surename,
            Titel = customer.Titel,
            Description = customer.Description
        };

        internal static Contact Convert(this SevDeskCustomer customer)
        {
            var result = ((CreateCustomerRequest)customer).Convert();
            result.Id = customer.Id;
            return result;
        }

        internal static SevDeskCustomer Convert(this Contact contact) => new SevDeskCustomer() { Id = contact.Id, Name = contact.Name, VatNumber = contact.VatNumber };
        internal static SevUser Convert(this SevDeskUser user) => new SevUser() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Fullname = user.Fullname, LastName = user.LastName, Username = user.Username };
        internal static SevDeskUser Convert(this SevUser user) => new SevDeskUser() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Fullname = user.Fullname, LastName = user.LastName, Username = user.Username };
        internal static SevDeskCountry Convert(this StaticCountry country) => _countryConverter(country);
        internal static InvoicePos Convert(this CreateLineItemRequest lineItem) => new InvoicePos() { Name = lineItem.Name, PriceNet = lineItem.PriceNet, Quantity = lineItem.Quantity, Text = lineItem.Text, unity = UnityTypes.GetUnity(lineItem.UnityType) };
    }
}