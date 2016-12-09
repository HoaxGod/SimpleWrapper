using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Entities._837_Professional
{
    public class Header_Professional_837
    {
        public Header_Professional_837()
        {
            this.PER_AdministrativeCommunicationContact_Professional_837 = new HashSet<PER_AdministrativeCommunicationContact_Professional_837>();
            this.InfoSource_Professional_837 = new HashSet<InfoSource_Professional_837>();
        }
        [Key]
        public int Headerkey { get; set; }
        public Nullable<int> Groupkey { get; set; }
        public string ST01_TransactionSetIdentifierCode { get; set; }
        public string ST02_TransactionSetControlNumber { get; set; }
        public string ST03_ImplementationConventionReference { get; set; }
        public string BHT01_HierarchStructCode { get; set; }
        public string BHT02_TranSetPurposeCode { get; set; }
        public string BHT03_RefId { get; set; }
        public string BHT04_Date { get; set; }
        public string BHT05_Time { get; set; }
        public string BHT06_TranTypeCode { get; set; }
        public string NM102_SubmitterTypeQlfr { get; set; }
        public string NM103_SubmitterLastOrOrganizationName { get; set; }
        public string NM104_SubmitterFirst { get; set; }
        public string NM105_SubmitterMiddle { get; set; }
        public string NM108_SubmitterIdCodeQlfr { get; set; }
        public string NM109_SubmitterIdCode { get; set; }
        public string PER02_SubmitterContactName { get; set; }
        public string PER0X_SubmitterPhoneNo { get; set; }
        public string PER0X_SubmitterPhoneExtNo { get; set; }
        public string PER0X_SubmitterFaxNo { get; set; }
        public string PER0X_SubmitterEmail { get; set; }
        public string NM102_ReceiverTypeQlfr { get; set; }
        public string NM103_ReceiverLastOrOrganizationName { get; set; }
        public string NM108_ReceiverIdCodeQlfr { get; set; }
        public string NM109_ReceiverIdCode { get; set; }

        public virtual FuncGroup_Professional_837 FuncGroup_Professional_837 { get; set; }
        public virtual ICollection<PER_AdministrativeCommunicationContact_Professional_837> PER_AdministrativeCommunicationContact_Professional_837 { get; set; }
        public virtual ICollection<InfoSource_Professional_837> InfoSource_Professional_837 { get; set; }
    }
}
