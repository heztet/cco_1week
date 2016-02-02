using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneWeek.DAL
{
    public class CounselContext : DbContent
    {
        public CounselContext() : base("CounselContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Counselor> Counselors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}