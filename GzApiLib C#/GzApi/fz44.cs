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
    public class ComplaintsDto
    {
        public object complaintNumber { get; set; }
        public object complaintId { get; set; }
        public object hasComplaint { get; set; }
    }

    public class HeaderBlock
    {
        public string purchaseNumber { get; set; }
        public object orderShared { get; set; }
        public object publishedDate { get; set; }
        public object publishedEtpDate { get; set; }
        public string timeZoneAbbrev { get; set; }
        public ComplaintsDto complaintsDto { get; set; }
        public object nmck { get; set; }
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
        public string currencySymbol { get; set; }
    }

    public class PrintFormLink
    {
        public string link { get; set; }
        public object title { get; set; }
        public object show { get; set; }
    }

    public class ActualNotice
    {
        public string docTypeCode { get; set; }
        public string timeZoneAbbrev { get; set; }
        public object publishDate { get; set; }
        public PrintFormLink printFormLink { get; set; }
        public string docNum { get; set; }
        public object changeLotNum { get; set; }
        public string orderType { get; set; }
    }

    public class TabsBlock
    {
        public string regNumber { get; set; }
        public string placingWay { get; set; }
        public object manyLots { get; set; }
        public object structuredProtocolTabs { get; set; }
        public object showSupplierResultsTab { get; set; }
        public string timeZoneAbbrev { get; set; }
        public IList<ActualNotice> actualNotices { get; set; }
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

    public class PlacementGeneralInformationOfPurchase
    {
        public string powerOfOrganization { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public object orderShared { get; set; }
        public object organizationId { get; set; }
        public object show { get; set; }
    }

    public class RelationshipWithRPG
    {
        public string link { get; set; }
        public object title { get; set; }
        public object show { get; set; }
    }

    public class WebAddressOfElectronicPlatform
    {
        public string link { get; set; }
        public string title { get; set; }
        public object show { get; set; }
    }

    public class GeneralInformationOnPurchaseBlock
    {
        public string wayDefinitionOfSupplier { get; set; }
        public PlacementGeneralInformationOfPurchase placementGeneralInformationOfPurchase { get; set; }
        public object additionalInformationOnChange { get; set; }
        public IList<RelationshipWithRPG> relationshipWithRPG { get; set; }
        public NumberStandardContract numberStandardContract { get; set; }
        public object requisitesOfLegalAct { get; set; }
        public object publicDiscussion { get; set; }
        public object interBudgetaryTransfer { get; set; }
        public string stageOfPurchase { get; set; }
        public object medicinePurchase { get; set; }
        public object budgetUnionState { get; set; }
        public object purchasesAbroad { get; set; }
        public string organizationRole { get; set; }
        public object article15PartType { get; set; }
        public object lifeCycleCases { get; set; }
        public string orderName { get; set; }
        public object nameOfSubjectPurchase { get; set; }
        public string nameOfSubjectPurchaseForOther { get; set; }
        public string nameOfElectronicPlatform { get; set; }
        public WebAddressOfElectronicPlatform webAddressOfElectronicPlatform { get; set; }
        public object goz { get; set; }
        public object part2Article84 { get; set; }
        public object willContractLifeCycle { get; set; }
        public object organizationRoleTKO { get; set; }
    }

    public class NumberStandardContract
    {
        public string link { get; set; }
        public string title { get; set; }
        public object show { get; set; }
    }

    public class OrganizationDefinitionSupplierBlock
    {
        public string organizationProvidingAccommodation { get; set; }
        public string postAddress { get; set; }
        public string location { get; set; }
        public object specOrgUrl { get; set; }
        public object specOrgAddress { get; set; }
        public object specOrgLocation { get; set; }
        public string responsibleOfficer { get; set; }
        public string emailAddress { get; set; }
        public string contactPhoneNumber { get; set; }
        public string fax { get; set; }
        public object informationAboutContractService { get; set; }
        public object additionalInformation { get; set; }
        public string organizationRoleType { get; set; }
        public object specOrgName { get; set; }
    }

    public class ProcedurePurchaseBlock
    {
        public object startDateTime { get; set; }
        public object endDateTime { get; set; }
        public string offerDeliverPlace { get; set; }
        public string offerDeliverProcedure { get; set; }
        public object additionalInformation { get; set; }
        public object offerOpenDate { get; set; }
        public object offerOpenPlace { get; set; }
        public object offerReviewDate { get; set; }
        public object offerReviewInfo { get; set; }
        public object offerReviewPlace { get; set; }
        public object prolongDate { get; set; }
        public object quotBidForm { get; set; }
        public object contractPeriod { get; set; }
        public object conditionsParticAviod { get; set; }
        public object offerOpenInfo { get; set; }
        public object preselectDate { get; set; }
        public object preselectPlace { get; set; }
        public object transferOfferOpenDate { get; set; }
        public object finalOfferOpenDate { get; set; }
        public object finalOfferOpenPlace { get; set; }
        public object finalOfferOpenInfo { get; set; }
        public object preselect { get; set; }
        public object offerReviewFirstPartDate { get; set; }
        public object offerReviewSecondPartDate { get; set; }
        public object actualOfferEndDate { get; set; }
        public object offerDiscussPlace { get; set; }
        public object offerDiscussDate { get; set; }
        public object offerReviewFirstPartFlag { get; set; }
        public object dateTime { get; set; }
        public object newDateTime { get; set; }
        public object newTime { get; set; }
        public object endReviewDate { get; set; }
        public object newOfferReviewFirstPDate { get; set; }
        public object newOfferReviewSecondPDate { get; set; }
        public object newActualOfferEndDate { get; set; }
        public object newOfferEndDate { get; set; }
        public object existsPublishedUIA { get; set; }
        public object closedAuctionDate { get; set; }
    }

    public class InitialContractPriceBlock
    {
        public double initialContractPrice { get; set; }
        public object interBudgetaryTransfer { get; set; }
        public string currency { get; set; }
        public object financeSource { get; set; }
        public IList<string> ikz { get; set; }
        public object contractPaymentPlan { get; set; }
        public object notNeedObozDescription { get; set; }
        public object oboz { get; set; }
        public object restrictsVendorSelect { get; set; }
        public object contractCurrency { get; set; }
        public object currencyRate { get; set; }
        public object currencyCbRate { get; set; }
        public object nmckContractCurrency { get; set; }
        public object nmckContractCurrencyForeignCurrency { get; set; }
        public object currencyRateDate { get; set; }
        public object discussionNeed { get; set; }
        public object nominalRate { get; set; }
        public object imposDefWorkSize { get; set; }
        public object advancePercent { get; set; }
        public object obozStatus { get; set; }
        public object specifyContractPriceFormula { get; set; }
        public object contractPriceFormula { get; set; }
        public object hasContractPaymentPlan { get; set; }
        public object currencyNotEquals { get; set; }
    }

    public class PositionCode
    {
        public string name { get; set; }
        public object link { get; set; }
        public string code { get; set; }
    }

    public class PositionsInfo
    {
        public PositionCode positionCode { get; set; }
        public string positionName { get; set; }
        public string unit { get; set; }
        public object count { get; set; }
        public double priceForUnit { get; set; }
        public double cost { get; set; }
        public object customerCountTru { get; set; }
        public IList<object> additionalCharacteristicsTRU { get; set; }
        public object justificationInclusion { get; set; }
        public object positionId { get; set; }
        public object reasonCharacteristics { get; set; }
        public object ktru { get; set; }
        public object medicalProduct { get; set; }
    }

    public class Paging
    {
        public object rounded { get; set; }
        public object total { get; set; }
        public string recordsPerPage { get; set; }
        public object totalRounded { get; set; }
        public object pageCount { get; set; }
        public object criteriaPageNumber { get; set; }
        public object moreThanTen { get; set; }
        public string rssLink { get; set; }
        public object exceedCount { get; set; }
    }

    public class PurchaseObjectInfoBlock
    {
        public IList<PositionsInfo> positionsInfo { get; set; }
        public object medicinePositionsInfo { get; set; }
        public object purchaseDescription { get; set; }
        public object needPackInfo { get; set; }
        public object restrictsForeignServices { get; set; }
        public object showRestrictsForeignServices { get; set; }
        public Paging paging { get; set; }
        public object lotId { get; set; }
        public object showCountOrganization { get; set; }
        public object placingWay { get; set; }
        public object currencyRate { get; set; }
        public object currencyName { get; set; }
        public object totalCost { get; set; }
        public object totalCostByCurrency { get; set; }
        public object showUnit { get; set; }
        public object showQuantity { get; set; }
        public object showPrice { get; set; }
        public object showCost { get; set; }
        public string currencySymbol { get; set; }
        public object showMedicalProduct { get; set; }
        public object imposDefWorkSize { get; set; }
        public object medicine { get; set; }
    }

    public class ParentRequirementsForParticipant
    {
        public string name { get; set; }
        public string additionalInformation { get; set; }
        public object featureId { get; set; }
        public object parentId { get; set; }
        public object lvl { get; set; }
    }

    public class AllRequirementsForParticipantsMap
    {
    }

    public class RestrictionsAndProhibition
    {
        public string name { get; set; }
        public string additionalInformation { get; set; }
    }

    public class LotRestrictionNpaDtoList
    {
        public object typeId { get; set; }
        public object npaId { get; set; }
        public string npaText { get; set; }
        public string typeText { get; set; }
        public object reason { get; set; }
        public object addInfo { get; set; }
        public object exclusion { get; set; }
    }

    public class LotRestrictionNpaPagingDto
    {
        public object rounded { get; set; }
        public object total { get; set; }
        public string recordsPerPage { get; set; }
        public object totalRounded { get; set; }
        public object pageCount { get; set; }
        public object criteriaPageNumber { get; set; }
        public object moreThanTen { get; set; }
        public string rssLink { get; set; }
        public object exceedCount { get; set; }
    }

    public class ConditionsBlock
    {
        public IList<object> advantages { get; set; }
        public IList<ParentRequirementsForParticipant> parentRequirementsForParticipants { get; set; }
        public AllRequirementsForParticipantsMap allRequirementsForParticipantsMap { get; set; }
        public IList<RestrictionsAndProhibition> restrictionsAndProhibitions { get; set; }
        public object showConditions { get; set; }
        public object additionalInformation { get; set; }
        public object restrictsVendorSelect { get; set; }
        public IList<LotRestrictionNpaDtoList> lotRestrictionNpaDtoList { get; set; }
        public LotRestrictionNpaPagingDto lotRestrictionNpaPagingDto { get; set; }
        public string lotRestrictionNpaUrl { get; set; }
        public object lotId { get; set; }
        public object hasConditionsForExclusion { get; set; }
        public object notAbleToAbideJustification { get; set; }
        public object hasComment { get; set; }
    }

    public class ConditionsOfContract
    {
        public IList<string> deliveryPlace { get; set; }
        public string deliveryTime { get; set; }
        public object initialContractPrice { get; set; }
        public object currency { get; set; }
        public object interBudgetaryTransfer { get; set; }
        public object show { get; set; }
        public object btkNumber { get; set; }
        public object unilateralRefusal { get; set; }
    }

    public class KbkTotalAmountByYearMaps
    {
    }

    public class KbkTotalAmountByYearMapsFormated
    {
    }

    public class KbkAfter2016TotalAmountByYearMaps
    {
    }

    public class KbkAfter2016TotalAmountByYearMapsFormated
    {
    }

    public class KvrTotalAmountByYearMaps
    {
    }

    public class KvrTotalAmountByYearMapsFormated
    {
    }

    public class TotalCommonRow
    {
        public string financialSource { get; set; }
        public string kbkKosguKvr { get; set; }
        public string firstYearAmount { get; set; }
        public string secondYearAmount { get; set; }
        public string thirdYearAmount { get; set; }
        public string otherYearAmount { get; set; }
        public string totalYearAmount { get; set; }
    }

    public class AnnualPaymentPlanTable
    {
        public IList<object> budgetRowList { get; set; }
        public IList<object> extrabudgetRowList { get; set; }
        public object totalBudgetRow { get; set; }
        public TotalCommonRow totalCommonRow { get; set; }
        public object hasFinancialSourceColumn { get; set; }
        public object hasKbkKosguKvrColumn { get; set; }
        public object hasFirstYearAmountColumn { get; set; }
        public object hasSecondYearAmountColumn { get; set; }
        public object hasThirdYearAmountColumn { get; set; }
        public object hasOtherYearAmountColumn { get; set; }
        public object hasTotalAmountColumn { get; set; }
        public object hasTable { get; set; }
        public object columnAmount { get; set; }
        public string firstYearAmountColumnHeader { get; set; }
        public object secondYearAmountColumnHeader { get; set; }
        public object thirdYearAmountColumnHeader { get; set; }
        public object otherYearAmountColumnHeader { get; set; }
        public string totalAmountColumnHeader { get; set; }
        public string commonTotalRowTitle { get; set; }
        public string budgetTotalRowTitle { get; set; }
        public string extrabudgetTotalRowTitle { get; set; }
    }

    public class ContractPaymentPlan
    {
        public IList<object> years { get; set; }
        public IList<object> kbkList { get; set; }
        public KbkTotalAmountByYearMaps kbkTotalAmountByYearMaps { get; set; }
        public KbkTotalAmountByYearMapsFormated kbkTotalAmountByYearMapsFormated { get; set; }
        public IList<object> kbkAfter2016List { get; set; }
        public KbkAfter2016TotalAmountByYearMaps kbkAfter2016TotalAmountByYearMaps { get; set; }
        public KbkAfter2016TotalAmountByYearMapsFormated kbkAfter2016TotalAmountByYearMapsFormated { get; set; }
        public object kosguList { get; set; }
        public object kosguTotalAmountByYearMaps { get; set; }
        public object kosguTotalAmountByYearMapsFormated { get; set; }
        public IList<object> kvrList { get; set; }
        public KvrTotalAmountByYearMaps kvrTotalAmountByYearMaps { get; set; }
        public KvrTotalAmountByYearMapsFormated kvrTotalAmountByYearMapsFormated { get; set; }
        public object extraBudgetPayment { get; set; }
        public object total { get; set; }
        public AnnualPaymentPlanTable annualPaymentPlanTable { get; set; }
        public object hasAnnualPaymentPlanTable { get; set; }
    }

    public class InitialContractPrice
    {
        public object initialContractPrice { get; set; }
        public object interBudgetaryTransfer { get; set; }
        public string currency { get; set; }
        public object financeSource { get; set; }
        public IList<string> ikz { get; set; }
        public ContractPaymentPlan contractPaymentPlan { get; set; }
        public object notNeedObozDescription { get; set; }
        public object oboz { get; set; }
        public object restrictsVendorSelect { get; set; }
        public object contractCurrency { get; set; }
        public object currencyRate { get; set; }
        public object currencyCbRate { get; set; }
        public object nmckContractCurrency { get; set; }
        public object nmckContractCurrencyForeignCurrency { get; set; }
        public object currencyRateDate { get; set; }
        public object discussionNeed { get; set; }
        public object nominalRate { get; set; }
        public object imposDefWorkSize { get; set; }
        public object advancePercent { get; set; }
        public object obozStatus { get; set; }
        public object specifyContractPriceFormula { get; set; }
        public object contractPriceFormula { get; set; }
        public object hasContractPaymentPlan { get; set; }
        public object currencyNotEquals { get; set; }
    }

    public class EnsuringPurchase
    {
        public string securityRequired { get; set; }
        public object amountEnforcement { get; set; }
        public object currency { get; set; }
        public object enforcementProcedure { get; set; }
        public object paymentRequisites { get; set; }
        public object offerGrnt { get; set; }
    }

    public class PaymentRequisites
    {
        public string rs { get; set; }
        public string ls { get; set; }
        public string bik { get; set; }
    }

    public class EnsuringPerformanceContract
    {
        public string contractualSecurityRequired { get; set; }
        public object amountContractEnforcement { get; set; }
        public string enforcementProcedure { get; set; }
        public PaymentRequisites paymentRequisites { get; set; }
        public object additionalInformation { get; set; }
        public string currency { get; set; }
        public object offerGrnt { get; set; }
        public object contractGrntShare { get; set; }
        public object smpSono { get; set; }
        public object energyServiceContract { get; set; }
    }

    public class BankSupportBlock
    {
        public string bankSupportType { get; set; }
        public string bankSupportTypeText { get; set; }
    }

    public class WarrantyObligations
    {
        public object warrantyObligations { get; set; }
        public object warrantyObligationsSize { get; set; }
        public object warrantyObligationsMethod { get; set; }
        public object warrantyObligationsAccount { get; set; }
        public object warrantyObligationsPersAccount { get; set; }
        public object warrantyObligationsBik { get; set; }
        public string warrantyObligationsRequisites { get; set; }
    }

    public class CustomerRequirementsBlock
    {
        public object organizationId { get; set; }
        public object customerId { get; set; }
        public string customerName { get; set; }
        public RelationshipWithRPG relationshipWithRPG { get; set; }
        public ConditionsOfContract conditionsOfContract { get; set; }
        public InitialContractPrice initialContractPrice { get; set; }
        public EnsuringPurchase ensuringPurchase { get; set; }
        public EnsuringPerformanceContract ensuringPerformanceContract { get; set; }
        public object singleCustomer { get; set; }
        public object showContractPaymentPlanInfo { get; set; }
        public BankSupportBlock bankSupportBlock { get; set; }
        public WarrantyObligations warrantyObligations { get; set; }
        public object discussionNeed { get; set; }
        public object imposDefWorkSize { get; set; }
    }

    public class CustomerRequirementsPagingDto
    {
        public object rounded { get; set; }
        public object total { get; set; }
        public string recordsPerPage { get; set; }
        public object totalRounded { get; set; }
        public object pageCount { get; set; }
        public object criteriaPageNumber { get; set; }
        public object moreThanTen { get; set; }
        public string rssLink { get; set; }
        public object exceedCount { get; set; }
    }

    public class StructuredDocumentationBlockDto
    {
        public object contractNecessaryGoodsCh9St37 { get; set; }
        public object modifiableContactCountGoods { get; set; }
        public object clarProcedureStartDate { get; set; }
        public object clarProcedureEndDate { get; set; }
        public string clarProcedureDelivery { get; set; }
        public object onesideRejectionCh9St37 { get; set; }
    }

    public class Dto
    {
        public HeaderBlock headerBlock { get; set; }
        public TabsBlock tabsBlock { get; set; }
        public string orderType { get; set; }
        public object featureFCSNF9370 { get; set; }
        public GeneralInformationOnPurchaseBlock generalInformationOnPurchaseBlock { get; set; }
        public OrganizationDefinitionSupplierBlock organizationDefinitionSupplierBlock { get; set; }
        public ProcedurePurchaseBlock procedurePurchaseBlock { get; set; }
        public InitialContractPriceBlock initialContractPriceBlock { get; set; }
        public PurchaseObjectInfoBlock purchaseObjectInfoBlock { get; set; }
        public ConditionsBlock conditionsBlock { get; set; }
        public object orderGrantingCompetitiveDocCommonBlock { get; set; }
        public IList<CustomerRequirementsBlock> customerRequirementsBlock { get; set; }
        public CustomerRequirementsPagingDto customerRequirementsPagingDto { get; set; }
        public object publicDiscussionBlock { get; set; }
        public object singleCustomer { get; set; }
        public object procedurePurchaseBlockSt2 { get; set; }
        public object tenderDocumentationBlockDto { get; set; }
        public StructuredDocumentationBlockDto structuredDocumentationBlockDto { get; set; }
    }

    public class Data
    {
        public Dto dto { get; set; }
    }

    public class fz44
    {
        public Data data { get; set; }
        public object error { get; set; }
    }

    class Program
    {
        public async Task Main(string[] args)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string request = "https://zakupki.gov.ru/api/mobile/proxy/917/epz/order/notice/ea44/view/common-info.html?regNumber=0338300015620000044";

                HttpResponseMessage response = (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                fz44 fz44 = JsonConvert.DeserializeObject<fz44>(responseBody);
            }
        } 
    }
}

