using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Schedule
    {

        public Schedule()
        {

        }

        public Employee Employee { get; set; }

        [DataType(DataType.Date)]
        public DateTime Day{ get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        public Customer Customer { get; set; }

    }
}
