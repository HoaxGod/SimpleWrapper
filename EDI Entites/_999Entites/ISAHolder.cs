using EDI_Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Entites._999Entites
{
    public class ISAHolder
    {

        public ISAHolder()
        {
            this.Interchange_999 = new HashSet<Interchange_999>();
        }
        [Key]
        public int IncomingFileID { get; set; }
        public virtual ICollection<Interchange_999> Interchange_999 { get; set; }
    }
}
