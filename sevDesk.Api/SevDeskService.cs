using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using SevDeskClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace sevDesk.Api
{
    public class SevDeskService : ISevDeskService
    {
        #region Properties

        private readonly SevDeskServiceOptions _options;
        private readonly RestClient _restClient;

        #endregion

        #region Constructor

        public SevDeskService(SevDeskServiceOptions options)
        {
            _options = options;
            _restClient = new RestClient(new Uri("https://my.sevdesk.de/api/v1/"));

            //_restClient.DefaultParameters.RemoveParameter("token");
            //_restClient.AddDefaultParameter("token", token, ParameterType.Querystring);
            _restClient.AddDefaultHeader("Authorization", _options.Token);

            var defaultSettings = new JsonSerializerSettings
            {
                ContractResolver = new JsonPropertiesResolver(),
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.None,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };

            _restClient.UseNewtonsoftJson(defaultSettings);
        }

        #endregion

        #region Helper

        private string _objectName<T>() where T : SevClientObject, new() => new T().ObjectName;

        #endregion

        #region ISevDeskService

        public async Task<GetListResult<T>> GetListAsync<T>(int limit = 0, string[] embed = null, KeyValuePair<string, string>[] filter = null, bool depht = true, bool countAll = true, CancellationToken cancellationToken = default)
            where T : SevClientObject, new()
        {
            var restRequest = new RestRequest();
            restRequest.Resource = _objectName<T>();
            restRequest.AddParameter("depth", depht);
            restRequest.AddParameter("limit", "200");
            restRequest.AddParameter("offset", "0");
            restRequest.AddParameter("countAll", countAll);

            if (filter != null)
            {
                foreach (var item in filter)
                {
                    restRequest.AddParameter(item.Key, item.Value);
                }
            }

            if (embed != null)
            {
                foreach (var item in embed)
                {
                    embed[Array.IndexOf(embed, item)] = item;
                }
                restRequest.AddParameter("embed", string.Join(",", embed));
            }

            var response = await _restClient.GetAsync(restRequest, cancellationToken);
            var deserialized = JsonConvert.DeserializeAnonymousType(response.Content, new { total = new int?(), objects = new List<T>() }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore, NullValueHandling = NullValueHandling.Ignore });

            if (limit == 0 & deserialized.objects != null)
            {
                limit = 200;
                while (deserialized.objects.Count < deserialized.total - 1)
                {
                    restRequest.AddOrUpdateParameter("offset", limit);
                    limit = limit + 200;

                    response = _restClient.GetAsync(restRequest).Result;
                    deserialized.objects.AddRange(JsonConvert.DeserializeAnonymousType(response.Content, new { total = new int(), objects = new List<T>() }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore, NullValueHandling = NullValueHandling.Ignore }).objects.ToList());
                }
            }

            return new GetListResult<T>()
            {
                Result = deserialized.objects == null ? new List<T>() : deserialized.objects.ToList(),
                StatusCode = response.StatusCode
            };
        }

        public async Task<GetResult<T>> GetAsync<T>(string id, string[] embed = null, CancellationToken cancellationToken = default)
            where T : SevClientObject, new()
        {

            var restRequest = new RestRequest();
            restRequest.Resource = $"{_objectName<T>()}/{id}";

            if (embed != null)
            {
                foreach (var item in embed)
                {
                    embed[Array.IndexOf(embed, item)] = item;
                }
                restRequest.AddParameter("embed", string.Join(",", embed));
            }

            restRequest.RequestFormat = DataFormat.Json;
            var response = await _restClient.GetAsync(restRequest, cancellationToken);

            var deserialized = JsonConvert.DeserializeAnonymousType(response.Content, new { total = new int?(), objects = new List<T>() }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore, NullValueHandling = NullValueHandling.Ignore }).objects[0];
            return new GetResult<T>()
            {
                Result = deserialized,
                StatusCode = response.StatusCode
            };
        }

        public async Task<PutResult<T>> UpdateAsync<T>(T item, CancellationToken cancellationToken = default)
            where T : SevClientObject, new()
        {
            var restRequest = new RestRequest();
            restRequest.Resource = $"{_objectName<T>()}/{item.Id}";

            restRequest.AddJsonBody(item);
            restRequest.RequestFormat = DataFormat.Json;
            var response = await _restClient.PutAsync(restRequest, cancellationToken);

            var deserialized = (JsonConvert.DeserializeAnonymousType(response.Content, new { objects = (T)Activator.CreateInstance(typeof(T)) }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore })).objects;
            return new PutResult<T>()
            {
                Result = deserialized,
                StatusCode = response.StatusCode
            };
        }

        public async Task<PostResult<T>> AddAsync<T>(T item, CancellationToken cancellationToken = default)
            where T : SevClientObject, new()
        {

            var restRequest = new RestRequest();
            restRequest.Resource = _objectName<T>();
            restRequest.AddJsonBody(item);
            var response = await _restClient.PostAsync(restRequest, cancellationToken);

            var deserialized = (JsonConvert.DeserializeAnonymousType(response.Content, new { objects = (T)Activator.CreateInstance(typeof(T)) }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore })).objects;
            return new PostResult<T>()
            {
                Result = deserialized,
                StatusCode = response.StatusCode
            };
        }

        public async Task<DeleteResult> DeleteAsync<T>(string id, CancellationToken cancellationToken = default)
            where T : SevClientObject, new()
        {

            var restRequest = new RestRequest();
            restRequest.Resource = $"{_objectName<T>()}/{id}";
            restRequest.AddParameter("id", id);

            var response = await _restClient.DeleteAsync(restRequest, cancellationToken);
            return new DeleteResult()
            {
                StatusCode = response.StatusCode
            };
        }

        public async Task<MapTransactionsStatusResult> MapTransactionsAsync(CheckAccount checkAccount, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest();
            restRequest.Resource = $"{checkAccount.ObjectName}/{checkAccount.Id}/mapTransactions";
            restRequest.AddParameter("embed", "openReminderCharge");
            restRequest.Method = Method.Post;

            var response = await _restClient.ExecuteAsync(restRequest, cancellationToken);
            var deserialized = JsonConvert.DeserializeAnonymousType(response.Content, new { objects = new MapTransactionsResult() }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore }).objects;

            return new MapTransactionsStatusResult()
            {
                Result = deserialized,
                StatusCode = response.StatusCode
            };
        }

        public async Task<StreamResult<T>> GetPdfAsync<T>(T item, CancellationToken cancellationToken = default)
            where T : SevClientStreamObject, new()
        {
            var restRequest = new RestRequest();
            restRequest.Resource = $"{item.ObjectName}/{item.Id}/getPdf";
            restRequest.AddParameter("id", item.Id);
            restRequest.AddParameter("download", "true");

            Stream stream = null;
            var statusCode = HttpStatusCode.OK;
            try
            {
                stream = await _restClient.DownloadStreamAsync(restRequest, cancellationToken);
            }
            catch (Exception e)
            {
#warning TODO den richtigen error hier auswerten
                statusCode = HttpStatusCode.BadRequest;
            }

            return new StreamResult<T>()
            {
                Object = item,
                Stream = stream,
                StatusCode = statusCode
            };
        }

#warning TODO Document
        public async Task<StreamResult<Document>> DownloadAsync(Document document, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest();
            restRequest.Resource = $"{document.ObjectName}/{document.Id}/download";

            restRequest.AddParameter("id", document.Id);
            restRequest.AddParameter("download", "true");

            Stream stream = null;
            var statusCode = HttpStatusCode.OK;
            try
            {
                stream = await _restClient.DownloadStreamAsync(restRequest, cancellationToken);
            }
            catch (Exception e)
            {
#warning TODO den richtigen error hier auswerten
                statusCode = HttpStatusCode.BadRequest;
            }

            return new StreamResult<Document>()
            {
                Object = document,
                Stream = stream,
                StatusCode = statusCode
            };
        }

        public async Task<DownloadAndSaveResult<Document>> DownloadAsync(Document document, FileInfo fileInfo, CancellationToken cancellationToken = default)
        {
            var streamResult = await DownloadAsync(document, cancellationToken);
            if (streamResult.StatusCode != HttpStatusCode.OK)
            {
                return new DownloadAndSaveResult<Document>()
                {
                    Object = document,
                    FileInfo = fileInfo,
                    StatusCode = streamResult.StatusCode
                };
            }

            using (var writeStream = fileInfo.OpenWrite())
            {
                streamResult.Stream.CopyTo(writeStream);
            }

            fileInfo.CreationTime = (DateTime)document.Create;
            fileInfo.LastWriteTimeUtc = (DateTime)document.Update;

            return new DownloadAndSaveResult<Document>()
            {
                Object = document,
                FileInfo = fileInfo,
                StatusCode = streamResult.StatusCode
            };
        }

        public async Task<GetResult<string>> FactoryGetNextInvoiceNumberAsync(string invoiceType = "RE", bool useNextNumber = true, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest();
            restRequest.Resource = $"Invoice/Factory/getNextInvoiceNumber";

            restRequest.AddQueryParameter("invoiceType", invoiceType);
            restRequest.AddQueryParameter("useNextNumber", useNextNumber.ToString());
            restRequest.Method = Method.Get;

            var response = await _restClient.ExecuteAsync(restRequest, cancellationToken);
            var deserialized = JsonConvert.DeserializeAnonymousType(response.Content, new { objects = "" }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore }).objects;
            return new GetResult<string>()
            {
                Result = deserialized,
                StatusCode = response.StatusCode
            };
        }

        public async Task<FactoryInvoiceResult> FactorySaveInvoiceAsync(Invoice invoice, List<InvoicePos> positions, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest();
            restRequest.Resource = "Invoice/Factory/saveInvoice";

            if (string.IsNullOrWhiteSpace(invoice.invoiceNumber))
            {
                var invoiceNumberResult = await FactoryGetNextInvoiceNumberAsync(invoice.invoiceType, true, cancellationToken);
                if (invoiceNumberResult.StatusCode == HttpStatusCode.OK)
                {
                    invoice.invoiceNumber = invoiceNumberResult.Result;
                    invoice.header += $" {invoiceNumberResult.Result}";
                }
            }

            if (string.IsNullOrWhiteSpace(invoice.address))
            {
                restRequest.AddQueryParameter("takeDefaultAddress", "true");
            }
            restRequest.AddJsonBody(new { invoice = invoice, invoicePosSave = positions });
            restRequest.Method = Method.Post;

            var response = await _restClient.ExecuteAsync(restRequest, cancellationToken);
            invoice = JsonConvert.DeserializeAnonymousType(response.Content, new { objects = new { Invoice = new Invoice() } }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore }).objects.Invoice;
            return new FactoryInvoiceResult()
            {
                Invoice = invoice,
                StatusCode = response.StatusCode
            };
        }

        public async Task<HttpStatusResult> BookAmountAsync(Invoice invoice, CheckAccount checkAccount = null, string sumGross = "", CancellationToken cancellationToken = default)
        {
            sumGross = string.IsNullOrWhiteSpace(sumGross) ? invoice.sumGross : sumGross;
            checkAccount = checkAccount ?? new CheckAccount() { Id = "484485" }; // <- Kasse 484485

            var restRequest = new RestRequest();
            restRequest.Resource = $"Invoice/{invoice.Id}/bookAmount";
            restRequest.AddJsonBody(new
            {
                amount = sumGross,
                date = DateTimeOffset.Now.ToUnixTimeSeconds().ToString(),
                type = "N",
                checkAccount = checkAccount,
                createFeed = "true"
            });

            restRequest.Method = Method.Put;

            var response = await _restClient.ExecuteAsync(restRequest, cancellationToken);
            return new HttpStatusResult()
            {
                StatusCode = response.StatusCode
            };
        }

        public async Task<FactoryInvoiceResult> FactoryCreateInvoiceReminder(Invoice invoice, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest();
            restRequest.Resource = "Invoice/Factory/createInvoiceReminder";

            restRequest.AddJsonBody(new { invoice });
            restRequest.Method = Method.Post;

            var response = _restClient.ExecuteAsync(restRequest).Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new FactoryInvoiceResult()
                {
                    StatusCode = response.StatusCode
                };
            }

            var dunningInvoice = JsonConvert.DeserializeAnonymousType(response.Content, new { objects = new Invoice() }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore }).objects;

            dunningInvoice.status = "200";
            dunningInvoice.timeToPay = "7";
            if (invoice.dunningLevel >= 3)
            {
                dunningInvoice.header = $"Letzte Mahnung - Rechnung Nr. {invoice.invoiceNumber}";
            }
            dunningInvoice.sendDate = DateTime.Now.ToShortDateString();

            return await FactorySaveInvoiceAsync(dunningInvoice, null, cancellationToken);
        }

        public async Task<PostResult<TagRelation>> AddTagAsync<T>(Tag tag, T sevClientObject, CancellationToken cancellationToken = default)
            where T : SevClientObject
        {
            var tagRelation = new TagRelation();
            tagRelation.Tag = tag;
            tagRelation.Object = sevClientObject;

            var restRequest = new RestRequest();
            restRequest.Resource = tagRelation.ObjectName;
            restRequest.AddJsonBody(tagRelation);
            restRequest.Method = Method.Post;

            var response = await _restClient.ExecuteAsync(restRequest, cancellationToken);
            var deserialized = (JsonConvert.DeserializeAnonymousType(response.Content, new { objects = (TagRelation)Activator.CreateInstance(typeof(TagRelation)) }, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore })).objects;

            return new PostResult<TagRelation>()
            {
                Result = deserialized,
                StatusCode = response.StatusCode
            };
        }

        #endregion
    }

    public class HttpStatusResult
    {
        public HttpStatusCode StatusCode { get; set; }
    }

    public class GetResult<T> : HttpStatusResult
    {
        public T Result { get; set; }
    }

    public class GetListResult<T> : HttpStatusResult
    {
        public List<T> Result { get; set; }
    }

    public class PostResult<T> : HttpStatusResult
    {
        public T Result { get; set; }
    }

    public class PutResult<T> : HttpStatusResult
    {
        public T Result { get; set; }
    }

    public class DeleteResult : HttpStatusResult { }

    public class MapTransactionsStatusResult : HttpStatusResult
    {
        public MapTransactionsResult Result { get; set; }
    }

    public class StreamResult<T> : HttpStatusResult
        where T : SevClientStreamObject
    {
        public T Object { get; set; }
        public Stream Stream { get; set; }
    }

    public class DownloadAndSaveResult<T> : HttpStatusResult
        where T : SevClientStreamObject
    {
        public T Object { get; set; }
        public FileInfo FileInfo { get; set; }
    }

    public class FactoryInvoiceResult : HttpStatusResult
    {
        public Invoice Invoice { get; set; }
        public List<InvoicePos> InvoicePos { get; set; }
    }
}