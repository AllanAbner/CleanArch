using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CoursesViewModel GetCourses();
        void CreateCourse(CoursesViewModel coursesViewModel);
    }
}