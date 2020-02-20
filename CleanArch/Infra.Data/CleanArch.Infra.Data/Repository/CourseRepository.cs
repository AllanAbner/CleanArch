using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext dbContext;


        public CourseRepository(UniversityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Course course)
        {
            dbContext.Add(course);
            dbContext.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return dbContext.Courses;
        }
    }
}