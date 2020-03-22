using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Entities
{
    public class IssueEntity
    {
        public int intIssueHeaderID { get; set; }

        public string vcIssueNo { get; set; }

        public int intIssueDetailID { get; set; }

        public string vcItemCode { get; set; }

        public string vcItemDescription { get; set; }

        public string vcUnit { get; set; }

        public int IssuedQty { get; set; }

        public decimal decUnitPrice { get; set; }
        

        public decimal decDiscountedUnitValue { get; set; }

        public decimal decStockInHand { get; set; }
    }
}
