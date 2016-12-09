using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Entities._837_Professional
{
    public class FuncGroup_Professional_837
    {
        public FuncGroup_Professional_837()
        {
            this.Header_Professional_837 = new HashSet<Header_Professional_837>();
        }
        [Key]
        public int Groupkey { get; set; }
        public Nullable<int> Interkey { get; set; }
        public string GS01_FunctionalIdCode { get; set; }
        public string GS02_ApplicationSendersCode { get; set; }
        public string GS03_ApplicationReceiversCode { get; set; }
        public string GS04_Date { get; set; }
        public string GS05_Time { get; set; }
        public string GS06_GroupControlNumber { get; set; }
        public string GS07_ResponsibleAgencyCode { get; set; }
        public string GS08_VersionReleaseIDCode { get; set; }
        public string GE01_NumberOfTransactionSets { get; set; }
        public string GE02_GroupControlNumber { get; set; }

        public virtual Interchange_Professional_837 Interchange_Professional_837 { get; set; }
        public virtual ICollection<Header_Professional_837> Header_Professional_837 { get; set; }
    }
}
