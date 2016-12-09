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
    
    public class HI_HealthCareInfoCode_Professional_837
    {
        [Key]
        public int HIkey { get; set; }
        public Nullable<int> Claimskey { get; set; }
        public Nullable<int> Subscriberkey { get; set; }
        public Nullable<int> Dependentkey { get; set; }
        public string HI01_01_ConditionQualifierCode { get; set; }
        public string HI01_02_ConditionCode { get; set; }
        public string HI02_01_ConditionQualifierCode { get; set; }
        public string HI02_02_ConditionCode { get; set; }
        public string HI03_01_ConditionQualifierCode { get; set; }
        public string HI03_02_ConditionCode { get; set; }
        public string HI04_01_ConditionQualifierCode { get; set; }
        public string HI04_02_ConditionCode { get; set; }
        public string HI05_01_ConditionQualifierCode { get; set; }
        public string HI05_02_ConditionCode { get; set; }
        public string HI06_01_ConditionQualifierCode { get; set; }
        public string HI06_02_ConditionCode { get; set; }
        public string HI07_01_ConditionQualifierCode { get; set; }
        public string HI07_02_ConditionCode { get; set; }
        public string HI08_01_ConditionQualifierCode { get; set; }
        public string HI08_02_ConditionCode { get; set; }
        public string HI09_01_ConditionQualifierCode { get; set; }
        public string HI09_02_ConditionCode { get; set; }
        public string HI10_01_ConditionQualifierCode { get; set; }
        public string HI10_02_ConditionCode { get; set; }
        public string HI11_01_ConditionQualifierCode { get; set; }
        public string HI11_02_ConditionCode { get; set; }
        public string HI12_01_ConditionQualifierCode { get; set; }
        public string HI12_02_ConditionCode { get; set; }
    
        public virtual Claims_Professional_837 Claims_Professional_837 { get; set; }
        public virtual Dependent_Professional_837 Dependent_Professional_837 { get; set; }
        public virtual Subscriber_Professional_837 Subscriber_Professional_837 { get; set; }
    }
}
