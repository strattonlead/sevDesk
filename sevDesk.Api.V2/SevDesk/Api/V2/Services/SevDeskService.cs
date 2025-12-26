using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SevDesk.Api.V2.Models;
using SevDesk.Api.V2.Services.Models;

namespace SevDesk.Api.V2.Services
{
    public class SevDeskService
    {
        private readonly SevDeskClient _client;

        public SevDeskService(SevDeskClient client)
        {
            _client = client;
        }

        public async Task<Model_InvoiceResponse> CreateInvoiceAsync(CreateInvoiceRequest request, CancellationToken cancellationToken = default)
        {
            // 1. Resolve Contact
            Model_Invoice_contact contact = request.Contact;
            if (contact == null && request.CreateContact != null)
            {
                var createdContact = await CreateContactAsync(request.CreateContact, cancellationToken);
                if (createdContact != null && !string.IsNullOrEmpty(createdContact.Id))
                {
                    if (int.TryParse(createdContact.Id, out int contactId))
                    {
                        contact = new Model_Invoice_contact
                        {
                            Id = contactId,
                            ObjectName = "Contact"
                        };
                    }
                }
            }

            if (contact == null)
            {
                throw new ArgumentException("Contact is required");
            }

            // 2. Resolve Invoice Number (optional, if logic is missing from generated client)
            string invoiceNumber = request.InvoiceNumber;
            // Skipping Factory.GetNextInvoiceNumber as it's not available in generated client.

            // 3. Tax Rule Determination
            Model_Invoice_taxRule_id taxRuleId = Model_Invoice_taxRule_id.One; // Default
            if (!string.IsNullOrEmpty(request.TaxType))
            {
                if (request.TaxType == "noteu") taxRuleId = Model_Invoice_taxRule_id.Two;
                if (request.TaxType == "ss") taxRuleId = Model_Invoice_taxRule_id.OneOne;
            }

            var taxRule = new Model_Invoice_taxRule
            {
                Id = taxRuleId,
                ObjectName = Model_Invoice_taxRule_objectName.TaxRule
            };

            // 4. Prepare Invoice
            var invoice = new Model_Invoice
            {
                InvoiceNumber = invoiceNumber,
                InvoiceDate = request.InvoiceDate.ToString("yyyy-MM-dd"),
                Header = string.IsNullOrWhiteSpace(request.Header) ? $"Rechnung {invoiceNumber}" : request.Header,
                HeadText = request.HeadText,
                FootText = request.FootText,
                AddressCountry = request.AddressCountry,

                Contact = contact,
                ContactPerson = request.ContactPerson,
                // CreateUser is private set in generated model, cannot set it.

                Status = Model_Invoice_status.OneZeroZero, // Draft (100)
                InvoiceType = Model_Invoice_invoiceType.RE,

                TaxRule = taxRule,
                Currency = "EUR",
                ShowNet = true,
            };

            // 5. Prepare Positions
            var invoicePosSave = new List<Model_InvoicePos>();
            foreach (var item in request.LineItems)
            {
                invoicePosSave.Add(new Model_InvoicePos
                {
                    Name = item.Name,
                    Text = item.Text,
                    Quantity = (float)item.Quantity,
                    Price = (float)item.PriceNet, // Set Price instead of PriceNet (which is private set)
                    TaxRate = (float)(item.TaxRate ?? 19),
                    Unity = new Model_InvoicePos_unity
                    {
                        Id = GetUnityId(item.UnityType),
                        ObjectName = "Unity"
                    }
                });
            }

            // 6. Call SaveInvoice
            var saveInvoiceBody = new SaveInvoice
            {
                Invoice = invoice,
                InvoicePosSave = invoicePosSave
            };

            var result = await _client.Invoice.Factory.SaveInvoice.PostAsync(saveInvoiceBody, null, cancellationToken);
            return result?.Invoice;
        }

        public async Task<Model_ContactResponse> CreateContactAsync(CreateContactRequest request, CancellationToken cancellationToken = default)
        {
            if (!int.TryParse(request.ContactType ?? "3", out int contactTypeId))
            {
                contactTypeId = 3; // Default
            }

            var contact = new Model_Contact
            {
                Name = request.CompanyName,
                Surename = request.FirstName,
                Familyname = request.LastName,
                Titel = request.Title,
                Description = request.Description,
                VatNumber = request.VatNumber,
                Category = new Model_Contact_category
                {
                    Id = contactTypeId,
                    ObjectName = "Category"
                }
            };

            return await _client.Contact.PostAsync(contact, null, cancellationToken);
        }

        private int GetUnityId(string unityType)
        {
            // Simple mapping or fetch from cache.
            // For now, hardcode some common ones or default.
            // "stk" -> 1?
            // In a real implementation this should probably fetch available units or use an Enum mapping if known.
            return 1; // Placeholder
        }
    }
}
