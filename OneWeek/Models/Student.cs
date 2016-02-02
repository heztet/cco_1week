using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneWeek.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}