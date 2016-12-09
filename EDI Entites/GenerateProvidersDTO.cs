using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Entites
{
    public class GenerateProvidersDTO
    {
        public string NPI { get; set; }

        public bool IsChecked { get; set; }

        public int InterchangeKey { get; set; }

        public string CheckNumber { get; set; }
    }
}
