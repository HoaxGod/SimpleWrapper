using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Entites
{
    public class FileDetails
    {

        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string schemaName { get; set; }
       
    }
}
