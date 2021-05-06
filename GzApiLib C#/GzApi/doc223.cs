using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;


namespace GzApi
{
    public class Attachments
    {
        public object id { get; set; }
        public string description { get; set; }
        public string fileName { get; set; }
        public object publishDate { get; set; }
        public object version { get; set; }
        public object actual { get; set; }
    }

    public class NoticeInfoAttDtoList
    {
        public IList<Attachments> attachment { get; set; }
    }

    public class TimeZones
    {
        public object id { get; set; }
        public object offset { get; set; }
        public object ahead { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public object actual { get; set; }
    }

    public class Dat
    {
        public object protocolCancellations { get; set; }
        public object rejectionsDocs { get; set; }
        public object protocolsDocs { get; set; }
        public object protocolAllocations { get; set; }
        public object lotCancellationAttachmentsSize { get; set; }
        public object protocolsDocsSize { get; set; }
        public IList<object> extendedAttachments { get; set; }
        public object explanationAttachmentsSize { get; set; }
        public object explanationsDocs { get; set; }
        public object contractDocs { get; set; }
        public NoticeInfoAttDtoList noticeInfoAttDtoList { get; set; }
        public object lotCancellations { get; set; }
        public object contractAttachmentsSize { get; set; }
        public object rejectionAttachmentsSize { get; set; }
        public object isPurchaseMethodTypeMultipleIS { get; set; }
        public IList<TimeZones> timeZones { get; set; }
        public object protocolAllocationAttachmentsSize { get; set; }
        public object noticeInfoAttachmentsSize { get; set; }
        public object protocolCancellationAttachmentsSize { get; set; }
    }

    public class documents223
    {
        public Dat data { get; set; }
        public object error { get; set; }
    }

    class doc223
    {
        public async Task Main(string[] args)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string request =
                    "https://zakupki.gov.ru/api/mobile/proxy/917/epz/order/notice/ea44/view/documents.html?regNumber=0338300015620000044";

                HttpResponseMessage response = (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                documents223 doc223 = JsonConvert.DeserializeObject<documents223>(responseBody);
            }
        }
    }
}
