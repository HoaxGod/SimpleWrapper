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
    
    public class CAS_ClaimsAdjustment_Professional_837
    {
        [Key]
        public int CASkey { get; set; }
        public Nullable<int> OtherSubscriberInfokey { get; set; }
        public Nullable<int> ServiceLineAdjkey { get; set; }
        public string CAS01_ClaimAdjustmentGroupCode { get; set; }
        public string CAS02_ClaimAdjustmentReasonCode { get; set; }
        public string CAS03_ClaimAdjustmentMonetoryAmount { get; set; }
        public string CAS04_ClaimAdjustmentQuantity { get; set; }
        public string CAS05_ClaimAdjustmentReasonCode { get; set; }
        public string CAS06_ClaimAdjustmentMonetoryAmount { get; set; }
        public string CAS07_ClaimAdjustmentQuantity { get; set; }
        public string CAS08_ClaimAdjustmentReasonCode { get; set; }
        public string CAS09_ClaimAdjustmentMonetoryAmount { get; set; }
        public string CAS10_ClaimAdjustmentQuantity { get; set; }
        public string CAS11_ClaimAdjustmentReasonCode { get; set; }
        public string CAS12_ClaimAdjustmentMonetoryAmount { get; set; }
        public string CAS13_ClaimAdjustmentQuantity { get; set; }
        public string CAS14_ClaimAdjustmentReasonCode { get; set; }
        public string CAS15_ClaimAdjustmentMonetoryAmount { get; set; }
        public string CAS16_ClaimAdjustmentQuantity { get; set; }
        public string CAS17_ClaimAdjustmentReasonCode { get; set; }
        public string CAS18_ClaimAdjustmentMonetoryAmount { get; set; }
        public string CAS19_ClaimAdjustmentQuantity { get; set; }
    
        public virtual OtherSubscriberInfo_Professional_837 OtherSubscriberInfo_Professional_837 { get; set; }
        public virtual ServiceLineAdj_Professional_837 ServiceLineAdj_Professional_837 { get; set; }
    }
}
