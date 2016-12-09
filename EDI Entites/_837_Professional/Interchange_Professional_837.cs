//using EDI.Entities.EDILogger;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Entities._837_Professional
{
    public class Interchange_Professional_837
    {
        public Interchange_Professional_837()
        {
            this.FuncGroup_Professional_837 = new HashSet<FuncGroup_Professional_837>();
        }
        [Key]
        public int Interkey { get; set; }
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
        public string IEA01_NumberofIncludedFunctionalGroups { get; set; }
        public string IEA02_InterchangeControlNo { get; set; }
        //newly Added column
        public int IncomingFileId { get; set; }
        [ForeignKey("IncomingFileId")]
        //public IncomeingFileLogger IncomingFileLogger { get; set; }
        public virtual ICollection<FuncGroup_Professional_837> FuncGroup_Professional_837 { get; set; }
    }
}
