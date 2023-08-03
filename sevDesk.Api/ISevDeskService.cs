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
        Task<SevDeskCustomer> CreateCustomerAsync(CreateCustomerRequest createCustomerRequest, CancellationToken cancellationToken = default);
        Task<SevDeskUser> GetContactPerson(string id, CancellationToken cancellationToken = default);
        Task<SevDeskUser> GetAnyContactPerson(CancellationToken cancellationToken = default);
        Task<List<Unity>> GetUnitsAsync(CancellationToken cancellationToken = default);
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
    public class SevDeskCustomer : CreateCustomerRequest
    {
        public string Id { get; set; }
    }

    public class CreateCustomerRequest
    {
        public string Surename { get; set; }
        public string Familyname { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string VatNumber { get; set; }
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
        public SevDeskCustomer Customer { get; set; }
        public CreateCustomerRequest CreateCustomer { get; set; }

        /// <summary>
        /// Kontaktperson im Unternehmen
        /// </summary>
        public SevDeskUser ContactPerson { get; set; }

        /// <summary>
        /// SevDesk User der die Rechnung erstellt hat. Wenn kein Wert gesetzt ist wird die ContactPerson verwendet
        /// </summary>
        public SevDeskUser CreatedBy { get; set; }
        public List<CreateLineItemRequest> LineItems { get; set; } = new List<CreateLineItemRequest>();

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
        public SevDeskCountry AddressCountry { get; set; }
        public SevDeskCustomer Customer { get; set; }
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
    }
}