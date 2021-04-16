﻿using SchoolBoard.Data;
using SchoolBoard.Data.EntityModels;
using SchoolBoard.Models;
using SchoolBoard.Models.PostModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBoard.Services
{
    public class PostService
    {
        private readonly Guid _userId;
        public PostService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    Title = model.Name,
                    Body = model.Body,
                    Instructor = model.Instructor,
                    InstructorId = model.InstructorId,
                    Student = model.Student,
                    StudentId = model.StudentId
                    
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Posts
                    .Select(
                        e =>
                        new PostListItem
                        {
                            Id = e.Id,
                            Name = e.Title,
                            Body = e.Body,
                            InstructorId = e.InstructorId,
                            Instructor = e.Instructor,
                            Student = e.Student,
                            StudentId = e.StudentId
                        });
                return query.ToArray();
            }
        }
        public PostDetail GetPostById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.Id == id);
                return
                    new PostDetail
                    {
                        Id = entity.Id,
                        Name = entity.Title,
                        Body = entity.Body,
                        Instructor = entity.Instructor,
                        InstructorId = entity.InstructorId,
                        Student = entity.Student,
                        StudentId = entity.StudentId
                    };


            }
        }
        public bool UpdatePost(PostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.Id == model.Id);
                entity.Id = model.Id;
                entity.Title = model.Name;
                entity.Body = model.Body;
                return ctx.SaveChanges() == 1;
            }

        }
        public bool DeletePost(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Posts
                    .Single(e => e.Id == id);
                ctx.Posts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }

}
    