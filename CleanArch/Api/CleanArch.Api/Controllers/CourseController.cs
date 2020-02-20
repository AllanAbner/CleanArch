using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CoursesViewModel model)
        {
            try
            {
                _courseService.CreateCourse(model);

                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}