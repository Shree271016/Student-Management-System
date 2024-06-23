using Microsoft.AspNetCore.Mvc;
using Student.Services;

namespace Student_Management_System.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;


        public CourseController(ICourseService courseService) => _courseService = courseService;

        public IActionResult Index(int pageNumber =1 , int pageSize = 10)
        {
            return View(_courseService.GetAll(pageNumber, pageSize));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _courseService.GetCourseById(id);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(CourseViewModel vm)
        {
            _courseService.UpdatedCourse(vm);
            return RedirectToAction("Index");
        }


        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseViewModel vm) {
            _courseService.InsertCourse(vm);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _courseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }


        
    }
}
