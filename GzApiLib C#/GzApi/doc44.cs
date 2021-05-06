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
    public class complaintsDto
    {
        public object complaintNumber { get; set; }
        public object complaintId { get; set; }
        public object hasComplaint { get; set; }
    }

    public class headerBlock
    {
        public string purchaseNumber { get; set; }
        public object orderShared { get; set; }
        public object createdDate { get; set; }
        public object publishedDate { get; set; }
        public object changedDate { get; set; }
        public object publishedEtpDate { get; set; }
        public string timeZoneAbbrev { get; set; }
        public complaintsDto complaintsDto { get; set; }
        public double nmck { get; set; }
        public string stageOfPurchase { get; set; }
        public string placingWayName { get; set; }
        public string placingWayFZ { get; set; }
        public string purchaseObjectName { get; set; }
        public string organizationPublishName { get; set; }
        public string organizationPublishLink { get; set; }
        public object expirationDate { get; set; }
        public string cryptoSignLink { get; set; }
        public string printFormLink { get; set; }
        public object pdiscLink { get; set; }
        public string capitalRepairsLink { get; set; }
        public object targetEA { get; set; }
        public object protocolName { get; set; }
        public object subsystemType { get; set; }
        public object customerOrgType { get; set; }
        public object stageNumber { get; set; }
        public string orderType { get; set; }
        public object suspend { get; set; }
        public object isCentralized { get; set; }
        public object orderBlockingDTO { get; set; }
        public string currencySymbol { get; set; }
        public object multiLots { get; set; }
    }

    public class printFormLink
    {
        public string link { get; set; }
        public object title { get; set; }
        public object show { get; set; }
    }

    public class actualNotice
    {
        public string docTypeCode { get; set; }
        public string timeZoneAbbrev { get; set; }
        public object publishDate { get; set; }
        public printFormLink printFormLink { get; set; }
        public string docNum { get; set; }
        public object changeLotNum { get; set; }
        public string orderType { get; set; }
    }

    public class tabsBlock
    {
        public string regNumber { get; set; }
        public string placingWay { get; set; }
        public string placingWayCode { get; set; }
        public object manyLots { get; set; }
        public object structuredProtocolTabs { get; set; }
        public object showSupplierResultsTab { get; set; }
        public string timeZoneAbbrev { get; set; }
        public IList<actualNotice> actualNotices { get; set; }
        public string commonLink { get; set; }
        public string lotsLink { get; set; }
        public string docLink { get; set; }
        public object protocolName { get; set; }
        public object protocolMainInfoLink { get; set; }
        public object protocolChangeLink { get; set; }
        public object protocolCancelInfoLink { get; set; }
        public object protocolDocsLink { get; set; }
        public object protocolBidReviewLink { get; set; }
        public object protocolBidListLink { get; set; }
        public object decisionInfoLink { get; set; }
        public string supplierResultsLink { get; set; }
        public string eventLink { get; set; }
        public object changedStProtocol { get; set; }
        public object tabParams { get; set; }
        public string docTypeCode { get; set; }
    }

    public class CryptoSign
    {
        public string link { get; set; }
        public object title { get; set; }
        public object show { get; set; }
    }

    public class PrintForm
    {
        public string link { get; set; }
        public object title { get; set; }
        public object show { get; set; }
    }

    public class NotificationChangesNotification
    {
        public object id { get; set; }
        public CryptoSign cryptoSign { get; set; }
        public PrintForm printForm { get; set; }
        public string docName { get; set; }
        public object publishDate { get; set; }
        public string redactionStatus { get; set; }
        public string statusDoc { get; set; }
        public IList<object> attachments { get; set; }
        public object controlNotPass { get; set; }
        public string timeZoneAbbrev { get; set; }
        public object control { get; set; }
        public object protocol { get; set; }
        public object urlOfProtocol { get; set; }
        public IList<object> lotNumbers { get; set; }
        public object cancellationProtocol { get; set; }
        public object parentStatusDoc { get; set; }
        public object hidePrintForm { get; set; }
        public object controlOrgName { get; set; }
        public object protocolId { get; set; }
        public object stProtocolId { get; set; }
        public object controlresultDocs { get; set; }
        public object spzCode { get; set; }
        public object reason { get; set; }
        public object notice { get; set; }
        public object controlResultDocs { get; set; }
    }

    public class Attachment
    {
        public CryptoSign cryptoSign { get; set; }
        public string fileName { get; set; }
        public string linkDownload { get; set; }
        public string docFullName { get; set; }
        public string statusAttach { get; set; }
        public object fileSize { get; set; }
        public object publishDate { get; set; }
        public string timeZoneAbbrev { get; set; }
        public string fileSizeInfo { get; set; }
    }

    public class ProtocolsEp
    {
        public object id { get; set; }
        public CryptoSign cryptoSign { get; set; }
        public PrintForm printForm { get; set; }
        public string docName { get; set; }
        public object publishDate { get; set; }
        public string redactionStatus { get; set; }
        public string statusDoc { get; set; }
        public IList<attachment> attachments { get; set; }
        public object controlNotPass { get; set; }
        public string timeZoneAbbrev { get; set; }
        public object control { get; set; }
        public object protocol { get; set; }
        public object urlOfProtocol { get; set; }
        public object lotNumbers { get; set; }
        public object cancellationProtocol { get; set; }
        public object parentStatusDoc { get; set; }
        public object hidePrintForm { get; set; }
        public object controlOrgName { get; set; }
        public object protocolId { get; set; }
        public object stProtocolId { get; set; }
        public object controlresultDocs { get; set; }
        public object spzCode { get; set; }
        public object reason { get; set; }
        public string protocolDocType { get; set; }
        public object procedureDate { get; set; }
        public string docNameUrl { get; set; }
        public object controlResultDocs { get; set; }
        public object notice { get; set; }
    }

    public class attachment
    {
        public CryptoSign cryptoSign { get; set; }
        public string fileName { get; set; }
        public string linkDownload { get; set; }
        public string docFullName { get; set; }
        public string statusAttach { get; set; }
        public object fileSize { get; set; }
        public object publishDate { get; set; }
        public string timeZoneAbbrev { get; set; }
        public string fileSizeInfo { get; set; }
    }

    public class StructuredDocumentation
    {
        public object id { get; set; }
        public CryptoSign cryptoSign { get; set; }
        public PrintForm printForm { get; set; }
        public string docName { get; set; }
        public object publishDate { get; set; }
        public string redactionStatus { get; set; }
        public string statusDoc { get; set; }
        public IList<attachment> attachments { get; set; }
        public object controlNotPass { get; set; }
        public string timeZoneAbbrev { get; set; }
        public object control { get; set; }
        public object protocol { get; set; }
        public object urlOfProtocol { get; set; }
        public object lotNumbers { get; set; }
        public object cancellationProtocol { get; set; }
        public object parentStatusDoc { get; set; }
        public object hidePrintForm { get; set; }
        public object controlOrgName { get; set; }
        public object protocolId { get; set; }
        public object stProtocolId { get; set; }
        public object controlresultDocs { get; set; }
        public object spzCode { get; set; }
        public object reason { get; set; }
        public object notice { get; set; }
        public object controlResultDocs { get; set; }
    }

    public class dto
    {
        public headerBlock headerBlock { get; set; }
        public tabsBlock tabsBlock { get; set; }
        public string orderType { get; set; }
        public IList<NotificationChangesNotification> notificationChangesNotification { get; set; }
        public IList<object> organizationChanges { get; set; }
        public IList<object> agreement { get; set; }
        public IList<object> cancelDocs { get; set; }
        public IList<object> explainsDocs { get; set; }
        public object protocols { get; set; }
        public object acts { get; set; }
        public object noticeProlongGiveBids { get; set; }
        public object noticeProlongCancel { get; set; }
        public string status { get; set; }
        public string regNumber { get; set; }
        public object control_5_1_99 { get; set; }
        public List<ProtocolsEp> protocolsEp { get; set; }
        public List<StructuredDocumentation> structuredDocumentation { get; set; }
    }

    public class data
    {
        public dto dto { get; set; }
    }
 
    public class documents44
    {
        public data data { get; set; }
        public object error { get; set; }  
    }

    class doc44
    {
        public async Task Main(string[] args)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string request = "https://zakupki.gov.ru/api/mobile/proxy/917/epz/order/notice/ea44/view/documents.html?regNumber=0338300015620000044";

                HttpResponseMessage response = (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                documents44 doc44 = JsonConvert.DeserializeObject<documents44>(responseBody);
            }
        }
    }
}
