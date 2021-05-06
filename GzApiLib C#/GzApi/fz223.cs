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
    public class Purchase
    {
        public object id { get; set; }
        public object customerId { get; set; }
        public IList<object> contracts { get; set; }
    }

    public class PurchaseMethod
    {
        public object id { get; set; }
        public object changeable { get; set; }
        public object competitive { get; set; }
        public object digitalPurchase { get; set; }
        public object extended { get; set; }
        public object hasPhases { get; set; }
        public string methodType { get; set; }
        public string name { get; set; }
        public string hasPurchases { get; set; }
        public string status { get; set; }
        public object typal { get; set; }
        public object typalKind { get; set; }
    }

    public class TimeZone
    {
        public object id { get; set; }
        public object offset { get; set; }
        public object ahead { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public object actual { get; set; }
    }

    public class Currency
    {
        public object id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public object lastModifyDate { get; set; }
        public string digitalCode { get; set; }
        public string shortName { get; set; }
        public object startActiveDate { get; set; }
        public object endtActiveDate { get; set; }
        public object dateutv { get; set; }
        public object actual { get; set; }
    }

    public class Okei
    {
        public object id { get; set; }
        public string name { get; set; }
        public string charCode { get; set; }
        public string internationCharCode { get; set; }
        public string localName { get; set; }
        public string internationName { get; set; }
        public object actual { get; set; }
        public string digitalCode { get; set; }
    }

    public class Okpd2
    {
        public object id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Okved2
    {
        public object id { get; set; }
        public string section { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CommoditiesWorkServices
    {
        public object id { get; set; }
        public Okei okei { get; set; }
        public object amountOfCommodities { get; set; }
        public object impossibleToDetermineAttr { get; set; }
        public object orderNumber { get; set; }
        public object deliveryPlace { get; set; }
        public Okpd2 okpd2 { get; set; }
        public Okved2 okved2 { get; set; }
        public string additionalInfo { get; set; }
    }

    public class DeliveryPlace
    {
        public object regionId { get; set; }
        public string address { get; set; }
    }

    public class Application
    {
        public object id { get; set; }
        public object applicationDate { get; set; }
        public string applicationNumber { get; set; }
        public object customerName { get; set; }
        public object inn { get; set; }
        public object kpp { get; set; }
        public object ogrn { get; set; }
        public object physical { get; set; }
        public object price { get; set; }
        public Currency currency { get; set; }
        public object conditionProposals { get; set; }
        public string allowance { get; set; }
        public object allowanceQualyfingCompetition { get; set; }
        public object rejectionReason { get; set; }
        public object rejectionReasonQualyfingCompetition { get; set; }
        public string place { get; set; }
        public object lastPrice { get; set; }
        public object lastButOnePrice { get; set; }
        public object additionalPrice { get; set; }
        public object rating { get; set; }
        public object assessmentResult { get; set; }
        public object contractExecutionTerm { get; set; }
        public object commodityAmount { get; set; }
        public object applicationDateOnly { get; set; }
        public object applicationHours { get; set; }
        public object applicationMinutes { get; set; }
        public object identificationNumber { get; set; }
        public object additionalIdentificationNumber { get; set; }
        public object countryId { get; set; }
        public object country { get; set; }
        public object address { get; set; }
        public object impossibleToDeterminePrice { get; set; }
        public string priceInfo { get; set; }
        public object notRFResident { get; set; }
        public object notRFResidentInfo { get; set; }
        public object explanationRequestResult { get; set; }
        public object customerExplanationRequestReason { get; set; }
        public object rejectionReasonCode { get; set; }
        public object rejectionReasonCodeQualyfingCompetition { get; set; }
        public string commissionDecisionPlace { get; set; }
        public object contactSigned { get; set; }
        public object functionalCharacteristicsFinalOffer { get; set; }
        public object appCommodityDeliveryPlace { get; set; }
        public object calculatedPlace { get; set; }
        public object calculatedRating { get; set; }
        public IList<object> protocolFields { get; set; }
        public IList<object> protocolFieldsForPlace { get; set; }
        public IList<object> protocolFieldsForAllowance { get; set; }
        public IList<object> requirements { get; set; }
        public IList<object> customerExplanationRequests { get; set; }
        public IList<object> appLotCriterias { get; set; }
        public object provider { get; set; }
        public object notDishonest { get; set; }
    }

    public class LotApplication
    {
       public object id { get; set; }
       public object assessmentInformation { get; set; }
       public IList<Application> applications { get; set; }
       public IList<object> documentRequirements { get; set; }
       public object currency { get; set; }
       public object additionalPriceCurrency { get; set; }
       public object nonPrice { get; set; }
       public object offerInfo { get; set; }
       public object allocated { get; set; }
       public object assessmentOrder { get; set; }
       public IList<object> lotApplicationsCriteria { get; set; }
    }

    public class Lot
    {
       public object id { get; set; }
       public object ordinalNumber { get; set; }
       public string contractSubject { get; set; }
       public object startingContractPrice { get; set; }
       public object priceInformation { get; set; }
       public object impossibleToDeterminePrice { get; set; }
       public Currency currency { get; set; }
       public object exchangeRate { get; set; }
       public object exchangeRateDate { get; set; }
       public object startingContractPriceRub { get; set; }
       public IList<CommoditiesWorkServices> commoditiesWorkServiceses { get; set; }
       public object planPositionId { get; set; }
       public object planInfoId { get; set; }
       public object planId { get; set; }
       public string planType { get; set; }
       public string reestrNumber { get; set; }
       public object commodityPrice { get; set; }
       public object commodityPriceRub { get; set; }
       public object jointLot { get; set; }
       public object centralized { get; set; }
       public DeliveryPlace deliveryPlace { get; set; }
       public string deliveryPlaceIndication { get; set; }
       public string inputTypeNMSK { get; set; }
       public IList<object> lotCustomers { get; set; }
       public IList<LotApplication> lotApplications { get; set; }
       public IList<object> lotToLotCancellations { get; set; }
       public IList<object> lotToProtocolAllocations { get; set; }
       public IList<object> lotCriterias { get; set; }
    }

    public class NoticeInfo
    {
        public object id { get; set; }
        public string purchaseName { get; set; }
        public object contractorAgencyType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string patronymic { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public object fax { get; set; }
        public object additionalContactInfo { get; set; }
        public object applSubmissionCloseTime { get; set; }
        public object considerationSecondPartDate { get; set; }
        public object applExaminationTime { get; set; }
        public string customerName { get; set; }
        public string customerInn { get; set; }
        public string customerKpp { get; set; }
        public string customerOgrn { get; set; }
        public string customerFullAddress { get; set; }
        public string customerPostalAddress { get; set; }
        public string applSubmisionPlace { get; set; }
        public object applSubmisionStartDate { get; set; }
        public object summingupTime { get; set; }
        public string urlVsrz { get; set; }
        public object auctionTime { get; set; }
        public object pricesProvisionStartDate { get; set; }
        public object pricesProvisionEndDate { get; set; }
        public object pricesMatchingDate { get; set; }
        public object qualifyingCompetitionDate { get; set; }
        public object functionalFeaturesDiscussStartDate { get; set; }
        public object functionalFeaturesDiscussEndDate { get; set; }
        public object finalOffersProvisionStartDate { get; set; }
        public object finalOffersProvisionEndDate { get; set; }
        public object offersDiscussStartDate { get; set; }
        public object offersDiscussEndDate { get; set; }
        public object finalOffersExamDate { get; set; }
        public object additionalPricesProvisionStartDate { get; set; }
        public object additionalPricesProvisionEndDate { get; set; }
        public object additionalPricesMatchingDate { get; set; }
        public object envelopeOpeningTime { get; set; }
        public object quotationExaminationTime { get; set; }
        public IList<Lot> lots { get; set; }
    }

    public class Datas
    {
        public Purchase purchase { get; set; }
        public PurchaseMethod purchaseMethod { get; set; }
        public IList<TimeZone> timeZones { get; set; }
        public NoticeInfo noticeInfo { get; set; }
    }
  
    public class fz223
    {
        public Datas data { get; set; }
        public object error { get; set; }
    }

    class Prog
    {  
        public async Task Main(string[] args)
        {
            using (HttpClient http = new HttpClient())
            {

                string request = "https://zakupki.gov.ru/223/purchase/public/purchase/info/common-info.html?regNumber=32009211136&backUrl=3b4f82e3-53de-4354-b955-c9cf7756f98b";

                HttpResponseMessage response = (await http.GetAsync(request)).EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                fz223 fz223 = JsonConvert.DeserializeObject<fz223>(responseBody);
            }
        }
    }
}
