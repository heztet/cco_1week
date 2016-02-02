using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneWeek.Models
{
    public class Appointment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public virtual Student Student { get; set; }
        public virtual Counselor Counselor { get; set; }
    }
}