using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Serices
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public CoursesViewModel GetCourses()
        {
            return new CoursesViewModel
            {
                Courses = _repository.GetCourses()
            };
        }
    }
}