using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using EDI.Entities;

namespace EDI.Entities._837_Professional
{
    public class ClaimForm_837_P
    {
        //public ClaimForm_837_P()
        //{
        //    this.FormCreatedDate = System.DateTime.Today;
        //}


        public int ClaimForm_837_PID { get; set; }

        public long ClaimNumber { get; set; }

        public string FromDOS { get; set; }

        public string PatientName { get; set; }

        public string TotalCharges { get; set; }

        public string InsuranceCompany { get; set; }

        public string SecondaryClaim { get; set; }

        public string Status { get; set; }

        public string UserName { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime? FormCreatedDate { get; set; }
        
        public string ReasonForRejection { get; set; }

        public string ReasonToHold { get; set; }

        public string TranslationHeaderKey { get; set; }

        public string GenerationHeaderKey { get; set; }

        public virtual Subscriber_Professional_837 Subscriber_Professional_837 { get; set; }

        public int formTypeID { get; set; }

        public int claimFormStatusID { get; set; }

        //[ForeignKey("formTypeID")]
        //public FormType formType { get; set; }

        //[ForeignKey("claimFormStatusID")]
        //public ClaimFormStatus claimFormStatus { get; set; }

        public string Description { get; set; }

        public int? CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category   Category { get; set; }

        public int Claims_Professional_837ID { get; set; }

        [ForeignKey("Claims_Professional_837ID")]
        public virtual Claims_Professional_837 Claims_Professional { get; set; }

        public int? Claims_Institutional_Claimskey { get; set; }


       public DateTime LastModifiedDate {get;set;}

        public string FileType { get; set; }
        public string MemberID { get; set; }
        public string FacilityID { get; set; }
        public string RenderingProviderID { get; set; }
        public string BillingProviderID { get; set; }
        public string ReferringProviderID { get; set; }
        public string SupervisingProviderID { get; set; }
        public string AccountID { get; set; }

        public string AccountName { get; set; }
        public Int64? TeamId { get; set; }
        public string RoleID { get; set; }
        public string PCPID { get; set; }
        public string ReferenceTraceNo { get; set; }
        public string Pre_PatientCtrlNo { get; set; }
        public string AccessableID { get; set; }

        public string PatientCtrlNo { get; set; }

        public string SecondaryStatus { get; set; }
        public string Source { get; set; }
        public string Billername { get; set; }
       
        public int? ParentClaimID { get; set; }
        [ForeignKey("ParentClaimID")]
        public ClaimForm_837_P ParentClaim { get; set; }
    }
}
