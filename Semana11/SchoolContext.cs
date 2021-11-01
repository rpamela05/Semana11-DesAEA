using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Semana11.Models;

namespace Semana11
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = MyContextDB") { }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Deparments { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        public DbSet<Person> People { get; set; }
    }
}