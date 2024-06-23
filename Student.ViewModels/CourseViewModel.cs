using Student.Models;

namespace Student.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public CourseViewModel() { }

        public CourseViewModel(Course model)
        {
            Id = model.Id;
            Name = model.Name;
            Description = model.Description;
        }

        public Course ConvertViewModel(CourseViewModel model)
        {
            return new Course
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };
        }
    }
}
