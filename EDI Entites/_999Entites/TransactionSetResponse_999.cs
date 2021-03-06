//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDI_Entites._999Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class TransactionSetResponse_999
    {
        public TransactionSetResponse_999()
        {
            this.ImplementationDataSegment_999 = new HashSet<ImplementationDataSegment_999>();
        }
       [Key]
        public int TransactionSetResponsekey { get; set; }
        public Nullable<int> Headerkey { get; set; }
        public string AK201_TransactionSetIDCode { get; set; }
        public string AK202_TransactionSetControlNumber { get; set; }
        public string AK203_ImplementationConventionReference { get; set; }
        public string IK501_TransactionSetAcknowledgementCode { get; set; }
        public string IK502_FunctionalGroupSyntaxErrorCode { get; set; }
        public string IK503_FunctionalGroupSyntaxErrorCode { get; set; }
        public string IK504_FunctionalGroupSyntaxErrorCode { get; set; }
        public string IK505_FunctionalGroupSyntaxErrorCode { get; set; }
        public string IK506_FunctionalGroupSyntaxErrorCode { get; set; }
        public Nullable<int> TrackerKey { get; set; }
    
        public virtual Header_999 Header_999 { get; set; }
        public virtual ICollection<ImplementationDataSegment_999> ImplementationDataSegment_999 { get; set; }
    }
}
