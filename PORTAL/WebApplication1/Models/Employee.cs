using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public int EmployeeId { get; set; }
        public int SSO { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public int VacationDays { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }


    }

    



}
