using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Entities._837_Professional
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OtherInfo_Professional
    {
        [Key]
        public int OtherInfo_ProfessionalID { get; set; }
        public string PlanId { get; set; }
        public string InsuredId { get; set; }
        public string ReservedNUCCUse08_01 { get; set; }
        public string ReservedNUCCUse08_02 { get; set; }
        public string PER_OtherInsuredPhone { get; set; }
        public string OtherInsuredPolicyNo { get; set; }
        public string OtherInsuredNUCCUse_01 { get; set; }
        public string OtherInsuredNUCCUse_02 { get; set; }
        public string OtherInsuredPlanName { get; set; }
        public string PatientConditionRelatedToEmp { get; set; }
        public string PatientConditionRelatedToAutoAccident { get; set; }
        public string PatientConditionRelatedToAutoAccidentState { get; set; }
        public string PatientConditionRelatedToOtherAccident { get; set; }
        public string PatientConditionNUCCUse { get; set; }
        public string OtherClaimId { get; set; }
        public string OtherClaimIdNUCCUse { get; set; }
        public string InsurancePlanName { get; set; }
        public string InsuredOtherHealthBenefitPlan { get; set; }
        public string PatientOrAuthorizedSignature { get; set; }
        public string PatientOrAuthorizedSignatureDate { get; set; }
        public string InsuredSignature { get; set; }
        public string CurrentIllness { get; set; }
        public string DateOfCurrentIllnessQlfr { get; set; }
        public string PatientOtherDateQlfr { get; set; }
        public string PatientOtherDate { get; set; }
        public string PatientUnableToWorkDateFrom { get; set; }
        public string PatientUnableToWorkDateTo { get; set; }
        public string ReferringProviderQlfr { get; set; }
        public string PhysicianQlfr { get; set; }
        public string PhysicianDescription { get; set; }
        public string AdditionalClaimInfoNUCC { get; set; }
        public string OutsideLab { get; set; }
        public string ICDIdentifier { get; set; }
        public string ResubmissionCode { get; set; }
        public string ResubmissionReferenceNo { get; set; }
        public string FederalTaxIdNo { get; set; }
        public string PatientsAccountNo { get; set; }
        public string AcceptAssignment { get; set; }
        public string ReservedNUCCUse30 { get; set; }
        public string BillingProviderPhone { get; set; }
        public string RenderingProviderPin { get; set; }
        public string BillingNPI { get; set; }
        public string BillingGroupIdQlfr { get; set; }
        public string BillingGroupNumber { get; set; }
        public string FederalTaxIdType { get; set; }

    }
}
