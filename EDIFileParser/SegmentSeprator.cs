using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileParser
{
    public class SegmentSeprator
    {
        public List<string> ElementValue { get; set; }
        public string  SegmentName { get; set; }
        public string LoopTag { get; set; }

        public SegmentSeprator(string Segment, Delimiter Delimiter)
        {
            int Seperator = Segment.IndexOf(Delimiter.elementSeparator);
            SegmentName = Segment.Substring(0, Seperator);
            ElementValue=new List<string>();
            foreach (string item in Segment.Substring(Seperator+1).Split(Delimiter.elementSeparator))
            {
                ElementValue.Add(item);
            }
        }
    }
}
