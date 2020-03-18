using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Entities
{
    public class ServiceEntity
    {

        public int intIssueHeaderID { get; set; }

        public int intServiceID { get; set; }

        public string vcServiceName { get; set; }

        public decimal decPrice { get; set; }

        public int intPaymentMethodID { get; set; }

        public decimal decTotal { get; set; }

        public List<ServiceEntity> lstServiceSave { get; set; }

        public decimal decUnitPrice { get; set; }

        public int intItemID { get; set; }

        public decimal Issueqty { get; set; }

        public decimal decMeterialsTotal { get; set; }

        public List<ServiceEntity> lstAllIssueSave { get; set; }

        public List<ServiceEntity> lstItemIssue { get; set; }

        public decimal decDiscountedValue { get; set; }
    }


}
