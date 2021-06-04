﻿using Microsoft.EntityFrameworkCore;
using SchoolBoard.Data;
using SchoolBoard.Data.DataModels;
using SchoolBoard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBoard.Services
{
    public class CourseService : ICourse
    {
        private readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Create(Course course)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int courseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses
                .Include(c => c.Students);
        }

        public Course GetById(int id)
        {
            var course = _context.Courses
                 .Where(c => c.Id == id)
                      .Include(c => c.Instructor)
                      .Include(c => c.Students)
                            .ThenInclude(s => s.Posts)
                                .ThenInclude(p => p.Instructor)
                      .Include(c => c.Students)
                            .ThenInclude(s => s.Posts)
                                .ThenInclude(p => p.Replies)
                                    .ThenInclude(r => r.Instructor)
                  .FirstOrDefault();
            return course;

        }

        public IEnumerable<Course> GetByInstructor()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourse(int courseId, string Name, IEnumerable<Student> students, ApplicationUser instructor)
        {
            throw new NotImplementedException();
        }
    }
}
