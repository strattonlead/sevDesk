using System;
using System.Collections.Generic;

namespace SevDesk.Api.V2.Services.Models
{
    public class CreateInvoiceRequest
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public DateTime DeliveryDate { get; set; } = DateTime.Now;
        public int TimeToPay { get; set; }
        public string Header { get; set; }
        public string HeadText { get; set; }
        public string FootText { get; set; }

        public string AddressName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouseNumber { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCity { get; set; }
        public global::SevDesk.Api.V2.Models.Model_Invoice_addressCountry AddressCountry { get; set; }

        public global::SevDesk.Api.V2.Models.Model_Invoice_contact Contact { get; set; }
        public CreateContactRequest CreateContact { get; set; }

        public global::SevDesk.Api.V2.Models.Model_Invoice_contactPerson ContactPerson { get; set; }
        public global::SevDesk.Api.V2.Models.Model_Invoice_createUser CreatedBy { get; set; }

        public decimal? TaxRate { get; set; }
        public string TaxType { get; set; }

        public List<CreateLineItemRequest> LineItems { get; set; } = new List<CreateLineItemRequest>();

        // Removed CreatePdf as it is a separate operation in V2 (probably) or we can implement it as a subsequent call.
        // But for "CreateInvoice", we focus on creation.
    }

    public class CreateLineItemRequest
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public decimal Quantity { get; set; }
        public decimal PriceNet { get; set; }
        public decimal? TaxRate { get; set; }
        public string UnityType { get; set; } // e.g., "stk"
    }

    public class CreateContactRequest
    {
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VatNumber { get; set; }
        public string ContactType { get; set; } // Id of category
    }
}
