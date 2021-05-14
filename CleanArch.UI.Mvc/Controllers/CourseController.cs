using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.UI.Mvc.Controllers
{
    [Authorize]
    public class CourseController:Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public ActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            return View(model);
        }
    }
}
