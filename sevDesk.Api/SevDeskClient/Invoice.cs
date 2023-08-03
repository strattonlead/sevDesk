using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using sevDesk.Api;
using System;
using System.Collections.Generic;

namespace SevDeskClient
{
    public class Invoice : SevClientStreamObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "Invoice";

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("create")]
        public string create { get; set; }

        [JsonProperty("update")]
        public string update { get; set; }

        [JsonProperty("invoiceDate"), JsonConverter(typeof(DateFormatConverter), "dd.MM.yyyy")]
        public DateTime? InvoiceDate { get; set; } = DateTime.Now;

        [JsonProperty("header")]
        public string Header { get; set; } = "Rechnung";

        [JsonProperty("headText")]
        public string HeadText { get; set; }

        [JsonProperty("footText")]
        public string FootText { get; set; }

        /// <summary>
        /// Tage bis die Zahlung fällig wird
        /// </summary>
        [JsonProperty("timeToPay")]
        public int TimeToPay { get; set; } = 7;

        [JsonProperty("discountTime")]
        public string DiscountTime { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("addressName")]
        public string AddressName { get; set; }

        [JsonProperty("addressStreet")]
        public string AddressStreet { get; set; }

        [JsonProperty("AddressZip")]
        public string addressZip { get; set; }

        [JsonProperty("addressCity")]
        public string AddressCity { get; set; }

        [JsonProperty("addressCountry")]
        public StaticCountry AddressCountry { get; set; } = new StaticCountry();

        [JsonProperty("payDate")]
        public DateTime? PayDate { get; set; }

        /// <summary>
        /// Die Person die die Rechnung erstellt
        /// </summary>
        [JsonProperty("createUser")]
        public SevUser CreateUser { get; set; } = new SevUser();

        [JsonProperty("deliveryDate"), JsonConverter(typeof(DateFormatConverter), "dd.MM.yyyy")]
        public DateTime DeliveryDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; } = "100";

        [JsonProperty("smallSettlement")]
        public int SmallSettlement { get; set; }

        [JsonProperty("contactPerson")]
        public SevUser ContactPerson { get; set; } = new SevUser();

        [JsonProperty("taxRate")]
        public int TaxRate { get; set; } = 19;

        [JsonProperty("taxText")]
        public string TaxText { get; set; } = "Umsatzsteuer ausweisen";
        public int? dunningLevel { get; set; } = 0;
        public long? lastDunningDate { get; set; }
        public string addressParentName { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; } = "default";
        public PaymentMethod paymentMethod { get; set; }

        [JsonProperty("sendDate"), JsonConverter(typeof(DateFormatConverter), "dd.MM.yyyy")]
        public DateTime SendDate { get; set; }
        //public string sendDate { get; set; } = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
        public string originLastInvoice { get; set; }

        [JsonProperty("invoiceType")]
        public string InvoiceType { get; set; } = "RE";
        public string accountIntervall { get; set; }
        public string accountLastInvoice { get; set; }
        public string accountNextInvoice { get; set; }
        public string reminderTotal { get; set; }
        public string reminderDebit { get; set; }
        public string reminderDeadline { get; set; }
        public string reminderCharge { get; set; }
        public string addressParentName2 { get; set; }
        public string addressName2 { get; set; }
        public string addressGender { get; set; }
        public string accountEndDate { get; set; }
        public string address { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; } = "EUR";

        [JsonProperty("sumNet")]
        public string SumNet { get; set; }

        [JsonProperty("sumGross")]
        public string SumGross { get; set; } = "0";
        public string sumDiscounts { get; set; }
        public string sumNetForeignCurrency { get; set; }
        public string sumTaxForeignCurrency { get; set; }
        public string sumGrossForeignCurrency { get; set; }
        public string sumDiscountsForeignCurrency { get; set; }
        public string sumNetAccounting { get; set; }
        public string sumTaxAccounting { get; set; }
        public string sumGrossAccounting { get; set; }
        public string paidAmount { get; set; }
        public string customerInternalNote { get; set; }

        [JsonProperty("showNet")]
        public int ShowNet { get; set; }
        public string enshrined { get; set; }

        [JsonProperty("sendType")]
        public string SendType { get; set; } = "VP";
        public string deliveryDateUntil { get; set; }
        public string sendPaymentReceivedNotificationDate { get; set; }

        [JsonProperty("mapAll")]
        public bool MapAll => true;

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public Invoice()
        {

            // Standartwerte festlegen
            HeadText = "<p>wir erlauben uns, unsere Lieferung/Leistung wie folgt in Rechnung zu stellen:<br/></p>";
            //this.headText = SevDesk.textTemplates?.SingleOrDefault(s => s.Main == "1" & s.ObjectType == "RE" & s.TextType == "HEAD").Text ?? "";
            //FootText = "<p><font color = \"red\">BITTE BEACHTEN:<br/>" +
            //                "Das Protokoll für diese Wartung wurde, durch uns, elektronisch an Ihren Aufgabenträger übermittelt. Leider ist es uns nicht möglich zu prüfen ob dieser die Datenübermittlung erhalten hat, oder korrekt verarbeiten konnte. Bitte setzten Sie sich dazu mit Ihrem Aufgabenträger binnen 14 Tagen in Verbindung und lassen Sie sich den Erhalt des Wartungsprotokolls bestätigen. Wir behalten uns vor, nach 14 Tagen ab Rechnungsdatum, eine Bearbeitungsgebühr für einen nachträglichen Protokollversand zu erheben.</font></p>" +
            //                "<p>Leider ist es uns vorerst aus Technischen Gründen(PSD2 Umstellung der Banken) nicht mehr möglich Lastschriften einzuziehen. Wir bitten daher um Überweisung der Rechnung.</p>" +
            //                "<p>Wir bedanken uns für Ihren Auftrag und verbleiben</p>" +
            //                "<p>mit freundlichen Grüßen</p>" +
            //                "<p>Nach dem geltenden Schwarzarbeitbekämpfungsgesetz §14 Abs.4 Satz 1 Nr.9 UStG sind wir verpflichtet, Sie darauf hinzuweisen, dass Sie unsere Rechnung und Ihren Zahlungsbeleg zwei Jahre lang aufbewahren müssen.<br/></p>" +
            //                "<p>Gelieferte Waren bleiben, auch im verbautem Zustand, bis zur vollständigen Bezahlung, unser Eigentum.</p>";
            //this.footText = "<p>Wir bedanken uns für Ihren Auftrag und verbleiben</p>" +
            //                "<p>mit freundlichen Grüßen</p>" +
            //                "<p>Nach dem geltenden Schwarzarbeitbekämpfungsgesetz §14 Abs.4 Satz 1 Nr.9 UStG sind wir verpflichtet, Sie darauf hinzuweisen, dass Sie unsere Rechnung und Ihren Zahlungsbeleg zwei Jahre lang aufbewahren müssen.<br/></p>" +
            //                "<p>Gelieferte Waren bleiben, auch im verbautem Zustand, bis zur vollständigen Bezahlung, unser Eigentum.</p>";
            //this.footText = "<p style=\"font-size: 1em;\">Wir bedanken uns für Ihren Auftrag und verbleiben mit freundlichen Grüßen.<br></p><p style=\"margin-bottom: 15px; font-size: 0.8em; font-family: helvetica, sans-serif; color: rgb(51, 51, 51); overflow-wrap: break-word;\">Nach dem geltenden Schwarzarbeitbekämpfungsgesetz §14 Abs.4 Satz 1 Nr.9 UStG sind wir verpflichtet, Sie darauf hinzuweisen, dass Sie unsere Rechnung und Ihren Zahlungsbeleg zwei Jahre lang aufbewahren müssen.&nbsp;Gelieferte Waren bleiben, auch im verbautem Zustand, bis zur vollständigen Bezahlung, unser Eigentum.</p><hr style=\"margin-top: 15px; margin-bottom: 15px; border-right-width: 0px; border-bottom-width: 0px; border-left-width: 0px; border-right-style: initial; border-bottom-style: initial; border-left-style: initial; border-top-style: solid; border-top-color: rgb(204, 204, 204); font-size: 1em; font-family: helvetica, sans-serif; color: rgb(51, 51, 51);\"><p style=\"margin-bottom: 15px; font-size: 1em; font-family: helvetica, sans-serif; color: rgb(51, 51, 51); overflow-wrap: break-word;\">SEPA Lastschriftmandat für wiederkehrende Zahlungen - Bitte abtrennen und im Original zurück, falls gewünscht.</p><p style=\"margin-bottom: 15px; font-size: 0.8em; font-family: helvetica, sans-serif; color: rgb(51, 51, 51); overflow-wrap: break-word;\">Zahlungsempfänger: Umwelttechnik Ebert - Lauenhainer Hauptstraße 18 - 08451 Crimmitschau<br>Gläubiger-ID: DE29ZZZ00001932269 - Mandatsreferenz:&nbsp;[%KUNDENNUMMER%] <br>Ich ermächtige die Firma Umwelttechnik Ebert, Zahlungen von meinem Konto mittels Lastschrifteinzuziehen. Zugleich weise ich mein Kreditinstitut an, die von Umwelttechnik Ebert (Thomas Ebert) auf mein Kontogezogenen Lastschriften einzulösen.&nbsp;Hinweis: Ich kann innerhalb von acht Wochen, beginnend mit dem Belastungsdatum, die Erstattung des belasteten Betrages verlangen. Es gelten dabei die mit meinem Kreditinstitut vereinbarten Bedingungen</p><table style=\"font-size: 1.1em;\"><colgroup><col width=\"23.77521613832853%\"><col width=\"76.0806916426513%\"></colgroup><thead></thead><tbody><tr><td>Kontoinhaber:</td><td>[%ADRESSE%]</td></tr><tr><td>Kreditinstitut:</td><td>_________________________________________________________________<br></td></tr><tr><td>IBAN:</td><td>_________________________________________________________________</td></tr><tr><td>BIC:</td><td>_________________________________________________________________<br></td></tr><tr><td>Datum/Unterschrift:</td><td>[%RECHNUNGSDATUM%] /&nbsp;<br></td></tr></tbody></table>";
            //this.footText = SevDesk.textTemplates?.SingleOrDefault(s => s.Name == "Wartungsrechnung Fuß mit SEPA").Text ?? "";
        }
    }
}
