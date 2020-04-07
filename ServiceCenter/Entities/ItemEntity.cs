using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Entities
{
    public class ItemEntity
    {
        public int intItemID { get; set; }
        public int intMainCategoryID { get; set; }
        public int intSubCatDetailsID { get; set; }
        public int intBrandID { get; set; }
        public string vcItemCode { get; set; }
        public string vcItemDescription { get; set; }
        public int intAPIID { get; set; }
        public int intSAEID { get; set; }
        public int intEngineTypeID { get; set; }
        public int intPackingMethodID { get; set; }
        public string vcEngineType { get; set; }

        public decimal decStockInHand { get; set; }
        public decimal decUnitPrice { get; set; }
        public decimal GRNqty { get; set; }
        public decimal Discount { get; set; }
        public decimal value { get; set; }
        public decimal Discounted { get; set; }

        public string vcSubCategoryName { get; set; }

        public string vcUnit { get; set; }

        public int intGRNDetailID { get; set; }

        public List<ItemEntity> lstLastItem { get; set; }

        public List<ServiceEntity> lstServiceSave { get; set; }

        public decimal AleadyReturnedQty { get; set; }

        public int IsAleadyReturned { get; set; }


        public decimal Issueqty { get; set; }

        public int intIssueHeaderID { get; set; }





        public int intMeasureUnitID { get; set; }
        public string vcMeasureUnit { get; set; }
        public string vcMeasureUnitDesc { get; set; }

        public string vcAPI { get; set; }

        public string vcSAE { get; set; }


        public int decQty { get; set; }

        public decimal decDiscountedUnitValue { get; set; }

        public decimal DiscountedPrice { get; set; }
    }
}
