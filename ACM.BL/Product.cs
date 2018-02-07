using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product
    { 
        public string ProductName { get; set; }

        public string Description { get; set; }
        
        public decimal CurrentPrice{ get; set; } 

        public string PrintProduct()
        {
            StringBuilder productStringBuilder = new StringBuilder();
            productStringBuilder.Append("Product Name:" + ProductName + 
                "\r\nDescription:" + Description + "\r\nCurrent Price:" + CurrentPrice);
            return productStringBuilder.ToString();
        }
        
    }
}
