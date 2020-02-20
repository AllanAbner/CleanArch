using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Serices
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _repository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository repository, IMediatorHandler bus)
        {
            _repository = repository;
            _bus = bus;
        }

        public void CreateCourse(CoursesViewModel model)
        {
            var createCourseCommand =
                new CreateCourseCommand(model.Name, model.Description, model.ImageUrl);

            _bus.SendCommand(createCourseCommand)
                .GetAwaiter()
                .GetResult();
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