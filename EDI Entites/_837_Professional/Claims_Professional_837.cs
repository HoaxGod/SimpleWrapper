//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDI.Entities._837_Professional
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Claims_Professional_837
    {
        public Claims_Professional_837()
        {
            this.OtherSubscriberInfo_Professional_837 = new HashSet<OtherSubscriberInfo_Professional_837>();
            this.ServiceLine_Professional_837 = new HashSet<ServiceLine_Professional_837>();
            this.DTP_DateTimePeriod_Professional_837 = new HashSet<DTP_DateTimePeriod_Professional_837>();
            this.PWK_PaperWork_Professional_837 = new HashSet<PWK_PaperWork_Professional_837>();
            this.K3_FileInfo_Professional_837 = new HashSet<K3_FileInfo_Professional_837>();
            this.CRC_ConditionsIndicator_Professional_837 = new HashSet<CRC_ConditionsIndicator_Professional_837>();
            this.REF_ReferenceIdentification_Professional_837 = new HashSet<REF_ReferenceIdentification_Professional_837>();
            this.HI_HealthCareInfoCode_Professional_837 = new HashSet<HI_HealthCareInfoCode_Professional_837>();
            this.OtherInfo_Professional = new OtherInfo_Professional();
        }
    [Key]
        public int Claimskey { get; set; }
        public int Subscriberkey { get; set; }
        public Nullable<int> Dependentkey { get; set; }
        [ForeignKey("OtherInfo_Professional")]
        public Nullable<int> OtherInfo_Professional_OtherInfo_ProfessionalID { get; set; }

        public string CLM01_PatientControlNo { get; set; }
        public string CLM02_TotalClaimChargeAmount { get; set; }
        public string CLM05_01_PlaceOfServiceCode { get; set; }
        public string CLM05_03_ClaimFrequencyCode { get; set; }
        public string CLM06_SupplierSignatureIndicator { get; set; }
        public string CLM07_PlanParticipationCode { get; set; }
        public string CLM08_BenefitsAssignmentCertIndicator { get; set; }
        public string CLM09_ReleaseOfInformationCode { get; set; }
        public string CLM10_PatientSignatureSourceCode { get; set; }
        public string CLM11_01_RelatedCausesCode { get; set; }
        public string CLM11_02_RelatedCausesCode { get; set; }
        public string CLM11_03_RelatedCausesCode { get; set; }
        public string CLM11_04_AutoAccidentStateCode { get; set; }
        public string CLM11_05_CountryCode { get; set; }
        public string CLM112_SpecialProgramCode { get; set; }
        public string CLM120_DelayReasonCode { get; set; }
        public string DTP03_OnsetofCurrentIllnessInjuryDate { get; set; }
        public string DTP03_InitialTreatmentDate { get; set; }
        public string DTP03_LastSeenDate { get; set; }
        public string DTP03_AcuteManifestationDate { get; set; }
        public string DTP03_AccidentDate { get; set; }
        public string DTP03_LastMenstrualPeriodDate { get; set; }
        public string DTP03_LastXrayDate { get; set; }
        public string DTP03_HearVisionPrescriptDate { get; set; }
        public string DTP03_Disability { get; set; }
        public string DTP03_InitialDisabilityPeriodStart { get; set; }
        public string DTP03_InitialDisabilityPeriodEnd { get; set; }
        public string DTP03_LastWorkedDate { get; set; }
        public string DTP03_WorkReturnDate { get; set; }
        public string DTP03_HospitalizationAdmissionDate { get; set; }
        public string DTP03_HospitalizationDischargeDate { get; set; }
        public string DTP03_PropertyCasualtyFirstContactDate { get; set; }
        public string DTP03_RepricerReceivedDate { get; set; }
        public string CN101_ContractTypeCode { get; set; }
        public string CN102_ContractAmount { get; set; }
        public string CN103_ContractPercentage { get; set; }
        public string CN104_ContractCode { get; set; }
        public string CN105_TermsDiscountPercent { get; set; }
        public string CN106_ContractVersionIdentifier { get; set; }
        public string AMT02_PatientAmountPaid { get; set; }
        public string REF02_SpecialPaymentReferenceNumber { get; set; }
        public string REF02_MedicareVersionCode { get; set; }
        public string REF02_MammographyCertificationNumber { get; set; }
        public string REF02_ReferralNumber { get; set; }
        public string REF02_PriorAuthorizationNumber { get; set; }
        public string REF02_PayerClaimControlNumber { get; set; }
        public string REF02_ClinicalLabAmendmentNumber { get; set; }
        public string REF02_RepricedClaimReferenceNumber { get; set; }
        public string REF02_AdjRepricedClaimReferenceNo { get; set; }
        public string REF02_InvestigatDeviceExemptIdfr { get; set; }
        public string REF02_ValueAddedNetworkTraceNumber { get; set; }
        public string REF02_MedicalRecordNumber { get; set; }
        public string REF02_DemonstrationProjectIdentifier { get; set; }
        public string REF02_CarePlanOversightNumber { get; set; }
        public string NTE01_NoteReferenceCode { get; set; }
        public string NTE02_ClaimNoteText { get; set; }
        public string CR102_PatientWeightPounds { get; set; }
        public string CR104_Ambulance_Transport_Reason_Code { get; set; }
        public string CR106_TransportDistanceMiles { get; set; }
        public string CR109_RoundTripPurposeDescription { get; set; }
        public string CR110_StretcherPurposeDescription { get; set; }
        public string CR208_NatureOfConditionCode { get; set; }
        public string CR210_PatientConditionDescription { get; set; }
        public string CR211_PatientConditionDescription2 { get; set; }
        public string CRC02_HomeboundConditionCode { get; set; }
        public string CRC03_HomeboundIndicator { get; set; }
        public string CRC02_EPSDT_ConditionCodeAppliesIndicator { get; set; }
        public string CRC03_EPSDT_ConditionIndicator { get; set; }
        public string CRC04_EPSDT_ConditionIndicator2 { get; set; }
        public string CRC05_EPSDT_ConditionIndicator3 { get; set; }
        public string HI01_01_DiagnosisTypeCode { get; set; }
        public string HI01_02_DiagnosisCode { get; set; }
        public string HI02_01_DiagnosisTypeCode2 { get; set; }
        public string HI02_02_DiagnosisCode2 { get; set; }
        public string HI03_01_DiagnosisTypeCode3 { get; set; }
        public string HI03_02_DiagnosisCode3 { get; set; }
        public string HI04_01_DiagnosisTypeCode4 { get; set; }
        public string HI04_02_DiagnosisCode4 { get; set; }
        public string HI05_01_DiagnosisTypeCode5 { get; set; }
        public string HI05_02_DiagnosisCode5 { get; set; }
        public string HI06_01_DiagnosisTypeCode6 { get; set; }
        public string HI06_02_DiagnosisCode6 { get; set; }
        public string HI07_01_DiagnosisTypeCode7 { get; set; }
        public string HI07_02_DiagnosisCode7 { get; set; }
        public string HI08_01_DiagnosisTypeCode8 { get; set; }
        public string HI08_02_DiagnosisCode8 { get; set; }
        public string HI09_01_DiagnosisTypeCode9 { get; set; }
        public string HI09_02_DiagnosisCode9 { get; set; }
        public string HI10_01_DiagnosisTypeCode10 { get; set; }
        public string HI10_02_DiagnosisCode10 { get; set; }
        public string HI11_01_DiagnosisTypeCode11 { get; set; }
        public string HI11_02_DiagnosisCode11 { get; set; }
        public string HI12_01_DiagnosisTypeCode12 { get; set; }
        public string HI12_02_DiagnosisCode12 { get; set; }
        public string HI01_02_AnesthesiaSurgicalPrincipleProcedure { get; set; }
        public string HI02_02_AnesthesiaSurgicalProcedure { get; set; }
        public string HCP01_PricingMethodology { get; set; }
        public string HCP02_RepricedAllowedAmount { get; set; }
        public string HCP03_RepricedSavingAmount { get; set; }
        public string HCP04_RepricingOrganizationIdentifier { get; set; }
        public string HCP05_RepricingPerDiemFlatRateAmount { get; set; }
        public string HCP06_RepricedApprovAmbPatientGroupCode { get; set; }
        public string HCP07_RepricedApprovAmbPatientGroupAmount { get; set; }
        public string HCP13_RejectReasonCode { get; set; }
        public string HCP14_PolicyComplianceCode { get; set; }
        public string HCP15_ExceptionCode { get; set; }
        public string NM103_ReferringProviderLastName { get; set; }
        public string NM104_ReferringProviderLastFirst { get; set; }
        public string NM105_ReferringProviderLastMiddle { get; set; }
        public string NM107_ReferringProviderLastSuffix { get; set; }
        public string NM109_ReferringProviderIdentifier { get; set; }
        public string NM103_PrimaryCareProviderLastName { get; set; }
        public string NM104_PrimaryCareProviderLastFirst { get; set; }
        public string NM105_PrimaryCareProviderLastMiddle { get; set; }
        public string NM107_PrimaryCareProviderLastSuffix { get; set; }
        public string NM109_PrimaryCareProviderIdentifier { get; set; }
        public string NM102_RenderingProviderTypeQualifier { get; set; }
        public string NM103_RenderingProviderLastOrOrganizationName { get; set; }
        public string NM104_RenderingProviderFirst { get; set; }
        public string NM105_RenderingProviderMiddle { get; set; }
        public string NM107_RenderingProviderSuffix { get; set; }
        public string NM109_RenderingProviderIdentifier { get; set; }
        public string PRV03_ProviderTaxonomyCode { get; set; }
        public string NM103_LabFacilityName { get; set; }
        public string NM109_LabFacilityIdentifier { get; set; }
        public string N301_LabFacilityAddress1 { get; set; }
        public string N302_LabFacilityAddress2 { get; set; }
        public string N401_LabFacilityCity { get; set; }
        public string N402_LabFacilityState { get; set; }
        public string N403_LabFacilityZip { get; set; }
        public string N404_LabFacilityCountryCode { get; set; }
        public string N407_LabFacilityCountrySubdivisionCode { get; set; }
        public string PER02_LabFacilityContactName { get; set; }
        public string PER04_LabFacilityTelephoneNumber { get; set; }
        public string PER06_LabFacilityExtensionNumber { get; set; }
        public string NM103_SupervisingPhysicianLastName { get; set; }
        public string NM104_SupervisingPhysicianFirst { get; set; }
        public string NM105_SupervisingPhysicianMiddle { get; set; }
        public string NM107_SupervisingPhysicianSuffix { get; set; }
        public string NM109_SupervisingPhysicianIdentifier { get; set; }
        public string N301_AmbulancePickupAddress1 { get; set; }
        public string N302_AmbulancePickupAddress2 { get; set; }
        public string N401_AmbulancePickupCity { get; set; }
        public string N402_AmbulancePickupState { get; set; }
        public string N403_AmbulancePickupZip { get; set; }
        public string N404_AmbulancePickupCountryCode { get; set; }
        public string N407_AmbulancePickupCountrySubdivisionCode { get; set; }
        public string N103_AmbulanceDropOffLocation { get; set; }
        public string N301_AmbulanceDropOffAddress1 { get; set; }
        public string N302_AmbulanceDropOffAddress2 { get; set; }
        public string N401_AmbulanceDropOffCity { get; set; }
        public string N402_AmbulanceDropOffState { get; set; }
        public string N403_AmbulanceDropOffZip { get; set; }
        public string N404_AmbulanceDropOffCountryCode { get; set; }
        public string N407_AmbulanceDropOffCountrySubdivisionCode { get; set; }
    
        public virtual Subscriber_Professional_837 Subscriber_Professional_837 { get; set; }
        public virtual ICollection<OtherSubscriberInfo_Professional_837> OtherSubscriberInfo_Professional_837 { get; set; }
        public virtual ICollection<ServiceLine_Professional_837> ServiceLine_Professional_837 { get; set; }
        public virtual ICollection<DTP_DateTimePeriod_Professional_837> DTP_DateTimePeriod_Professional_837 { get; set; }
        public virtual ICollection<PWK_PaperWork_Professional_837> PWK_PaperWork_Professional_837 { get; set; }
        public virtual ICollection<K3_FileInfo_Professional_837> K3_FileInfo_Professional_837 { get; set; }
        public virtual ICollection<CRC_ConditionsIndicator_Professional_837> CRC_ConditionsIndicator_Professional_837 { get; set; }
        public virtual ICollection<REF_ReferenceIdentification_Professional_837> REF_ReferenceIdentification_Professional_837 { get; set; }
        public virtual ICollection<HI_HealthCareInfoCode_Professional_837> HI_HealthCareInfoCode_Professional_837 { get; set; }
        public virtual OtherInfo_Professional OtherInfo_Professional { get; set; }
    }
}