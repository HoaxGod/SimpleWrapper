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
    
    public class DTP_DateTimePeriod_Professional_837
    {
        [Key]
        public int DTPkey { get; set; }
        public Nullable<int> Claimskey { get; set; }
        public Nullable<int> ServiceLinekey { get; set; }
        public Nullable<int> Subscriberkey { get; set; }
        public Nullable<int> Dependentkey { get; set; }
        public string DTP01_DateTimeQualifier { get; set; }
        public string DTP03_AssumedRelinquishedCareDate { get; set; }
    
        public virtual Claims_Professional_837 Claims_Professional_837 { get; set; }
        public virtual Dependent_Professional_837 Dependent_Professional_837 { get; set; }
        public virtual ServiceLine_Professional_837 ServiceLine_Professional_837 { get; set; }
        public virtual Subscriber_Professional_837 Subscriber_Professional_837 { get; set; }
    }
}
