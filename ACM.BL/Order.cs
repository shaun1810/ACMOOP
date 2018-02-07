using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Order
    {

        public Product Product { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShippingAddress { get; set; }

    }
}
