using Student.Models;

namespace Student.Services
{
    public class CourseViewModel
    {
        private Course x;

        public CourseViewModel()
        {
        }

        public CourseViewModel(Course x)
        {
            this.x = x;
        }

        internal Course ConvertViewModel(CourseViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}