using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeData
{
    class Customer
    {
        public Customer(string firstName, string lastName, string email, string customerInterest, string contactStatus, string customerType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CustomerInterest = customerInterest;
            ContactStatus = contactStatus;
            CustomerType = customerType;
        }

        public Customer() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string CustomerInterest { get; set; }
        public string ContactStatus { get; set; }
        public string CustomerType { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName +
                ", Email Address : " + Email;/*       
                " CustomerInterest : " + CustomerInterest +
                " ContactStatus : " + ContactStatus +
                " CustomerType : " + CustomerType;*/

        }

    }
}
