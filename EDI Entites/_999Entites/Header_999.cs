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
    
    public partial class Header_999
    {
        public Header_999()
        {
            this.TransactionSetResponse_999 = new HashSet<TransactionSetResponse_999>();
            this.ImplementationDataSegment_999 = new HashSet<ImplementationDataSegment_999>();
            this.ImplementationDataElement_999 = new HashSet<ImplementationDataElement_999>();
        }

        [Key]
        public int Headerkey { get; set; }
        public Nullable<int> Groupkey { get; set; }
        public string ST01_TransactionSetIdentifierCode { get; set; }
        public string ST02_TransactionSetControlNumber { get; set; }
        public string ST03_ImplementationConventionReference { get; set; }
        public string AK901_FunctionalGroupAcknowledgmentCode { get; set; }
        public string AK902_NumberOfTransactionSetsIncluded { get; set; }
        public string AK903_NumberOfReceivedTransactionSets { get; set; }
        public string AK904_NumberOfAcceptedTransactionSets { get; set; }
        public string AK905_FunctionalGroupSyntaxErrorCode { get; set; }
        public string AK906_FunctionalGroupSyntaxErrorCode { get; set; }
        public string AK907_FunctionalGroupSyntaxErrorCode { get; set; }
        public string AK908_FunctionalGroupSyntaxErrorCode { get; set; }
        public string AK909_FunctionalGroupSyntaxErrorCode { get; set; }
        public string AK101_FunctionIdCode { get; set; }
        public string AK102_GroupControlNumber { get; set; }
        public string AK103_VersionReleaseIndustryIdentifierCode { get; set; }
    
        public virtual FunctionalGroup_999 FunctionalGroup_999 { get; set; }
        public virtual ICollection<TransactionSetResponse_999> TransactionSetResponse_999 { get; set; }
        public virtual ICollection<ImplementationDataSegment_999> ImplementationDataSegment_999 { get; set; }
        public virtual ICollection<ImplementationDataElement_999> ImplementationDataElement_999 { get; set; }
    }
}
