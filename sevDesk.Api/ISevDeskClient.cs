﻿using SevDeskClient;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace sevDesk.Api
{
    public interface ISevDeskClient
    {
        Task<GetListResult<T>> GetListAsync<T>(int limit = 0, string[] embed = null, KeyValuePair<string, string>[] filter = null, bool depht = true, bool countAll = true, CancellationToken cancellationToken = default)
            where T : SevClientObject, new();

        Task<GetResult<T>> GetAsync<T>(string id, string[] embed = null, CancellationToken cancellationToken = default)
            where T : SevClientObject, new();

        Task<PutResult<T>> UpdateAsync<T>(T item, CancellationToken cancellationToken = default)
            where T : SevClientObject, new();

        Task<PutResult<T>> UpdateAsync<T>(object id, object body, CancellationToken cancellationToken = default)
           where T : SevClientObject, new();

        Task<PostResult<T>> AddAsync<T>(T item, CancellationToken cancellationToken = default)
            where T : SevClientObject, new();

        Task<DeleteResult> DeleteAsync<T>(string id, CancellationToken cancellationToken = default)
            where T : SevClientObject, new();

        Task<MapTransactionsStatusResult> MapTransactionsAsync(CheckAccount checkAccount, CancellationToken cancellationToken);

        Task<StreamResult<T>> GetPdfAsync<T>(T item, CancellationToken cancellationToken = default)
            where T : SevClientStreamObject, new();

        Task<DownloadAndSaveResult<Document>> DownloadAsync(Document document, FileInfo fileInfo, CancellationToken cancellationToken = default);

        Task<GetResult<string>> FactoryGetNextInvoiceNumberAsync(string invoiceType = "RE", bool useNextNumber = true, CancellationToken cancellationToken = default);

        Task<FactoryInvoiceResult> FactorySaveInvoiceAsync(Invoice invoice, List<InvoicePos> positions, CancellationToken cancellationToken = default);

        Task<HttpStatusResult> BookAmountAsync(Invoice invoice, CheckAccount checkAccount = null, string sumGross = "", CancellationToken cancellationToken = default);

        Task<FactoryInvoiceResult> FactoryCreateInvoiceReminder(Invoice invoice, CancellationToken cancellationToken = default);

        Task<PostResult<TagRelation>> AddTagAsync<T>(Tag tag, T sevClientObject, CancellationToken cancellationToken = default)
            where T : SevClientObject;
        Task<PostResult<Contact>> CreateContact(Contact contact, CancellationToken cancellationToken = default);
        Task<PostResult<Contact>> UpdateContact(Contact contact, CancellationToken cancellationToken = default);
        Task<FactoryOrderResult> FactorySaveOrderAsync(Order order, List<OrderPos> positions, CancellationToken cancellationToken = default);

        // TODO
        //Task<bool> CheckCustomerNumberAvailability(string customerNumber);
        Task<GetResult<string>> FactoryGetNextCustomerNumberAsync(CancellationToken cancellationToken = default);
        Task<GetResult<string>> FactoryGetNextOrderNumberAsync(string orderType = "AB", bool useNextNumber = true, CancellationToken cancellationToken = default);
        Task<GetResult<Template[]>> GetTemplatesWithThumbAsync(CancellationToken cancellationToken = default);
        Task<HttpStatusResult> ChangeParameterAsync<T>(T obj, string template, CancellationToken cancellationToken = default)
            where T : SevClientStreamObject;
    }
}