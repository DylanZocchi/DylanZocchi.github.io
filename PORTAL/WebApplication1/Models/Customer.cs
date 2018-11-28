using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public Customer()
        {

        }
        public string CustomerName { get; set; }

        public string Street { get; set; }

        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }
        public string City { get; set; }


        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

    }
}
