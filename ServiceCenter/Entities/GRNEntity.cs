using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Entities
{
    public class GRNEntity
    {
        public int intGRNHeaderID { get; set; }
        public string vcGRNNo { get; set; }
        public int intSupplierID { get; set; }
        public DateTime dtGRNDate { get; set; }
        public int intEnteredBy { get; set; }
        public decimal decTotal { get; set; }

        public int intItemID { get; set; }
        public decimal decGRNQty { get; set; }
        public decimal decUnitPrice { get; set; }
        public decimal decDiscount { get; set; }

        public decimal decDiscountedValue { get; set; }

        public List<GRNEntity> lstGRNSave { get; set; }
    }
}
