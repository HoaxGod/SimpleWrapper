//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDIEntites
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interchange_277_214
    {
        public Interchange_277_214()
        {
            this.FunctionalGroup_277_214 = new HashSet<FunctionalGroup_277_214>();
        }
    
        public int Interkey { get; set; }
        public int IncomingFileID { get; set; }
        public string ISA01_AuthorizationInformationQualifier { get; set; }
        public string ISA02_AuthorizationInformation { get; set; }
        public string ISA03_SecurityInformationQualifier { get; set; }
        public string ISA04_SecurityInformation { get; set; }
        public string ISA05_InterchangeIDQualifier { get; set; }
        public string ISA06_InterchangeSenderID { get; set; }
        public string ISA07_InterchangeIDQualifier { get; set; }
        public string ISA08_InterchangeReceiverID { get; set; }
        public string ISA09_InterchangeDate { get; set; }
        public string ISA10_InterchangeTime { get; set; }
        public string ISA11_RepetitionSeparator { get; set; }
        public string ISA12_InterchangeControlVersionNumber { get; set; }
        public string ISA13_InterchangeControlNumber { get; set; }
        public string ISA14_AcknowledgementRequested { get; set; }
        public string ISA15_UsageIndicator { get; set; }
        public string ISA16_ComponentElementSeparator { get; set; }
      //  public string IncomingFileID { get; set; }
        public string IEA01_NumberofIncludedFunctionalGroups { get; set; }
        public string IEA02_InterchangeControlNo { get; set; }
    
        public virtual ICollection<FunctionalGroup_277_214> FunctionalGroup_277_214 { get; set; }
    }
}
