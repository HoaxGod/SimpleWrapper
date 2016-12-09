using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Entities._837_Professional
{
   public  class ClaimLog
    {
        public int ID { get; set; }

       public DateTime ChangeSetDate { get; set; }

        //public string EventType { get; set; }

        //public string Entity { get; set; }

        public string FieldName { get; set; }

        //public string ColumnName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public string ClaimID { get; set; }

        public int Status { get; set; }

        public string LoggedBy { get; set; }
    }
}
