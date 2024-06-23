using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Services
{
    public interface ICourseService
    {
        PagedResult<CourseViewModel>GetAll(int pageNumber,int pageSize);
        CourseViewModel GetCourseById(int id);
        void UpdatedCourse(CourseViewModel model);
        void DeleteCourse(int id);
        void InsertCourse(CourseViewModel model);
    }
}
