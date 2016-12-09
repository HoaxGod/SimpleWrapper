using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Entites.Common
{
    public class IncomingFileloger
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string TypeOfFile { get; set; }
        public string DateOFEntry { get; set; }
        public string ClaimType { get; set; }
        public string dispatchstatus { get; set; }
        public string Source { get; set; }
        public string UserName { get; set; }

    }
}
