﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBoard.Data.DomainModels
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Instructor))]
        public string InstructorId { get; set; }
        public Guid InstructorGuid { get; set;  }
        public virtual ApplicationUser Instructor { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }
        public Student Student { get; set; }
    }
}