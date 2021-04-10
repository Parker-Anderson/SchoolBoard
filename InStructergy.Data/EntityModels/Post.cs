﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStructergy.Data.EntityModels
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstructorId { get; set; }
        public List<Student> Students { get; set; }
    }
}