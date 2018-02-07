using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(string firstName = null, string lastName = null, string email = null, string homeAddress = null, string workAddress = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.HomeAddress = homeAddress;
            this.WorkAddress = workAddress;
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public string Email { get; set; }

        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }
        
        public bool Validate { get; private set; }

        public string printCustomer()
        {
           StringBuilder customerDetailsBuilder = new StringBuilder();
           customerDetailsBuilder.Append("Customer Name: " + FullName + "\r\nEmail: " + Email 
               + "\r\nHome Address:" + HomeAddress + "\r\nWork Address:" + WorkAddress);
            return customerDetailsBuilder.ToString();
        }

    }
}
