﻿using System;
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

        public decimal decStockInHand { get; set; }
        public decimal decUnitPrice { get; set; }



       public string vcSubCategoryName { get; set; }

        public string vcUnit { get; set; }

        public List<ItemEntity> lstLastItem { get; set; }

    }
}
