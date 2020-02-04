using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Entities
{
    public class CompanyEntity
    {
        public int intCompanyID { get; set; }
        public string vcCompanyName { get; set; }
        public string vcAddress { get; set; }
        public int intContactNo { get; set; }
        public string vcCity { get; set; }
        public string vcEmail { get; set; }
        public string vcSupplierName { get; set; }
        public string vcDesignature { get; set; }
    }
}
