using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneWeek.DAL
{
    public class CounselInitializer : System.Data.Entity DropCreateDatabaseIfModelChanges<CounselContext>
    {
        protected override void Seed(CounselContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Nicky",LastName="Marino",PurdueID="0011111111"},
                new Student{FirstName="Johnny",LastName="Test",PurdueID="0022222222"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var appointments = new List<Appointment>
            {
                new Appointment{StudentID=1,Date=DateTime.Parse("2015-03-02"),Text=""},
                new Appointment{StudentID=1,Date=DateTime.Parse("2016-01-21"),Text=""}
            };

            appointments.ForEach(s => context.Appointments.Add(s));
            context.SaveChanges();

            var counselors = new List<Counselor>
            {
                new Counselor{FirstName="John",LastName="Purdue"}
            };

            counselors.ForEach(s => context.Counselors.Add(s));
            context.SaveChanges();
        }
    }
}