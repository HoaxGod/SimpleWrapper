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
    
    public class FRM_SupportingDocument_Professional_837
    {
        [Key]
        public int FRMkey { get; set; }
        public Nullable<int> ServiceDocumentkey { get; set; }
        public string FRM01_QuestionNumberLetter { get; set; }
        public string FRM02_QuestionResponseCode { get; set; }
        public string FRM03_QuestionResponse { get; set; }
        public string FRM04_QuestionResponseDate { get; set; }
        public string FRM05_QuestionResponsePercent { get; set; }
    
        public virtual ServiceDocument_Professional_837 ServiceDocument_Professional_837 { get; set; }
    }
}
