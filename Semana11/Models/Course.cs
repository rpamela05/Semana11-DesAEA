using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana11.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DeparmentID { get; set; }

        public virtual Department Deparment { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}