using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Entities
{
    public  class CustomerEntity
    {
        public int intCustomerID { get; set; }

        public string vcAddress { get; set; }

        public string vcCustomerName { get; set; }

        public string vcVehicleNo { get; set; }

        public string vcCity { get; set; }

        public int intContactNo { get; set; }

    }
}
