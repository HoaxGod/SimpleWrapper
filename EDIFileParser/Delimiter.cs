using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileParser
{
   public class Delimiter
    {
        #region Orgin Code
        public char segmentTerminator;
        public char elementSeparator;
        public char subElementSeparator;
       
       
        public Delimiter(string ISASegment)
        {
            elementSeparator = ISASegment[3];
            subElementSeparator = ISASegment[104];
            segmentTerminator = ISASegment[105];
        }

      
        #endregion

    }
}
