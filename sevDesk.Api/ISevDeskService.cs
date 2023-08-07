using Newtonsoft.Json;
using SevDeskClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace sevDesk.Api
{
    public interface ISevDeskService
    {
        string GetTaxType(SevDeskCountry source, SevDeskCountry destination);
        int GetDefaultTaxRate(string taxType);

        Task<SevDeskCountry> GetCountryAsync(string code, CancellationToken cancellationToken = default);
        Task<List<SevDeskCountry>> GetCountriesAsync(CancellationToken cancellationToken = default);
        Task<SevDeskInvoice> CreateInvoiceAsync(CreateInvoiceRequest createInvoiceRequest, CancellationToken cancellationToken = default);

        Task<SevDeskContact> CreateContactAsync(CreateContactRequest createCustomerRequest, CancellationToken cancellationToken = default);
        Task<SevDeskContact> UpdateContactAsync(UpdateContactRequest updateCustomerRequest, CancellationToken cancellationToken = default);
        Task<bool> DeleteContactAsync(string id, CancellationToken cancellationToken = default);
        Task<SevDeskContact> GetContactAsync(string id, CancellationToken cancellationToken = default);

        Task<SevDeskUser> GetContactPerson(string id, CancellationToken cancellationToken = default);
        Task<SevDeskUser> GetAnyContactPerson(CancellationToken cancellationToken = default);
        Task<List<Unity>> GetUnitsAsync(CancellationToken cancellationToken = default);
        Task<SevDeskOrder> CreateOrderAsync(CreateOrderRequest request, CancellationToken cancellationToken = default);
        Task<SevDeskOrder> UpdateOrderAsync(UpdateOrderRequest updateOrderRequest, CancellationToken cancellationToken = default);
        Task<string> GetNextOrderNumberAsync(OrderType orderType, CancellationToken cancellationToken = default);
    }

    public class SevDeskCountry
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Gemapped auf Contact
    /// </summary>
    public class SevDeskContact : CreateContactRequest
    {
        public string Id { get; set; }
    }

    public class CreateContactRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string ContactType { get; set; } = ContactTypes.Customer;

        /// <summary>
        /// Umsatzsteuer ID
        /// </summary>
        public string ValueAddedTaxId { get; set; }
    }

    public class ContactTypes
    {
        public const string Supplier = "2";
        public const string Customer = "3";
        public const string Partner = "4";
        public const string ProspectCustomer = "28";
    }

    public class UpdateContactRequest : SevDeskContact
    {
        public UpdateContactRequest() { }
        public UpdateContactRequest(SevDeskContact customer)
        {
            Id = customer.Id;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Title = customer.Title;
            Description = customer.Description;
            CompanyName = customer.CompanyName;
            ValueAddedTaxId = customer.ValueAddedTaxId;
        }
    }

    /// <summary>
    /// Das entspricht einem Mitarbeiter aus SevDesk
    /// </summary>
    public class SevDeskUser
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }

    public class CreateInvoiceRequest
    {
        public SevDeskCountry AddressCountry { get; set; }
        public SevDeskContact Contact { get; set; }
        public CreateContactRequest CreateContact { get; set; }

        /// <summary>
        /// Kontaktperson im Unternehmen
        /// </summary>
        public SevDeskUser ContactPerson { get; set; }

        /// <summary>
        /// SevDesk User der die Rechnung erstellt hat. Wenn kein Wert gesetzt ist wird die ContactPerson verwendet
        /// </summary>
        public SevDeskUser CreatedBy { get; set; }
        public List<CreateLineItemRequest> CreateLineItems { get; set; } = new List<CreateLineItemRequest>();

        public string AddressName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouseNumber { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCity { get; set; }

        /// <summary>
        /// Rechnungsdatum
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Lieferdatum / Leistungsdatum
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Anzahl Tage bis bezahlt werden muss
        /// </summary>
        public int TimeToPay { get; set; } = 14;

        /// <summary>
        /// Steuer z.b. 19. Wenn der Wert nicht gesetzt wird, dann werden die standard OSS Steuer Raten genommen
        /// </summary>
        public int? TaxRate { get; set; }

        /// <summary>
        /// PDF direkt erstellen. Die Rechnung ist dann finalisiert!!
        /// </summary>
        public bool CreatePdf { get; set; }
    }

    public class SevDeskLineItem : CreateLineItemRequest
    {
        public string Id { get; set; }
    }

    public class CreateLineItemRequest
    {
        /// <summary>
        /// Anzahl
        /// </summary>
        public int Quantity { get; set; } = 1;

        /// <summary>
        /// Nettopreis
        /// </summary>
        public decimal PriceNet { get; set; }

        /// <summary>
        /// Name der Position
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Beschreibung des Postens
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Abweichende Steuer, null = automatisch
        /// </summary>
        public int? TaxRate { get; set; }

        /// <summary>
        /// Einheit kommt aus UnityTypes. Die Id angeben
        /// </summary>
        public string UnityType { get; set; }
    }

    public static class UnityTypes
    {
        public static Unity GetUnity(string id)
        {
            switch (id)
            {
                case "1":
                    return PIECES;
                case "2":
                    return SQUARE_METERS;
                case "3":
                    return METERS;
                case "4":
                    return KILOGRAM;
                case "5":
                    return TONS;
                case "6":
                    return LFM;
                case "7":
                    return FLAT_RATE;
                case "8":
                    return CUBIC_METERS;
                case "9":
                    return HOURS;
                case "10":
                    return KILOMETERS;
                case "11":
                    return PERCENT;
                case "13":
                    return DAYS;
                case "15":
                    return L;
                case "37":
                default:
                    return EMPTY;
            }
        }
        /// <summary>
        /// Stk
        /// </summary>
        public static Unity PIECES => new Unity() { Id = "1" };

        /// <summary>
        /// m2
        /// </summary>
        public static Unity SQUARE_METERS => new Unity() { Id = "2" };

        /// <summary>
        /// Meter
        /// </summary>
        public static Unity METERS => new Unity() { Id = "3" };

        /// <summary>
        /// kg
        /// </summary>
        public static Unity KILOGRAM => new Unity() { Id = "4" };

        /// <summary>
        /// t (Tonnen)
        /// </summary>
        public static Unity TONS => new Unity() { Id = "5" };

        /// <summary>
        /// Laufende Festmeter
        /// </summary>
        public static Unity LFM => new Unity() { Id = "6" };

        /// <summary>
        /// Pauschal
        /// </summary>
        public static Unity FLAT_RATE => new Unity() { Id = "7" };

        /// <summary>
        /// m3
        /// </summary>
        public static Unity CUBIC_METERS => new Unity() { Id = "8" };

        /// <summary>
        ///  std Stunden
        /// </summary>
        public static Unity HOURS => new Unity() { Id = "9" };

        /// <summary>
        /// km
        /// </summary>
        public static Unity KILOMETERS => new Unity() { Id = "10" };

        /// <summary>
        /// Prozent
        /// </summary>
        public static Unity PERCENT => new Unity() { Id = "11" };

        /// <summary>
        /// Tage
        /// </summary>
        public static Unity DAYS => new Unity() { Id = "13" };

        /// <summary>
        /// L??
        /// </summary>
        public static Unity L => new Unity() { Id = "15" };

        /// <summary>
        /// Leer
        /// </summary>
        public static Unity EMPTY => new Unity() { Id = "37" };
    }

    public class SevDeskInvoice
    {
        public string Id { get; set; }
        public string InvoiceNumber { get; set; }
        public SevDeskCountry AddressCountry { get; set; }
        public SevDeskContact Contact { get; set; }
        public SevDeskUser ContactPerson { get; set; }
        public List<SevDeskLineItem> LineItems { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// Rechnungsdatum
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Lieferdatum / Leistungsdatum
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Anzahl Tage bis bezahlt werden muss
        /// </summary>
        public int TimeToPay { get; set; } = 14;

        /// <summary>
        /// Steuer z.b. 19. Wenn der Wert nicht gesetzt wird, dann werden die standard OSS Steuer Raten genommen
        /// </summary>
        public int? TaxRate { get; set; }

        [JsonIgnore]
        public Stream PdfStream { get; set; }

        public string Currency { get; set; }
        public decimal NetValue { get; set; }
        public decimal TaxValue { get; set; }
        public decimal GrossValue { get; set; }
    }
}