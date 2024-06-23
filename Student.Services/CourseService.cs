using Student.Models;
using Student.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Student.Services
{
    public class CourseService : ICourseService
    {
        private IUnitOfWork _unitOfWork;
        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteCourse(int id)
        {

            var model = _unitOfWork.GenericRepository<Course>().GetById(id);
            _unitOfWork.GenericRepository<Course>().Delete(model);
            _unitOfWork.Save();
        }


        public PagedResult<CourseViewModel> GetAll(int pageNumber, int pageSize)
        {

            var vm = new PagedResult<CourseViewModel>();
            int totalCount;
            List<CourseViewModel>vmList = new List<CourseViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                var modelList = _unitOfWork.GenericRepository<Course>().GetAll().Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Course>().GetAll().ToList().Count;
                vmList = ConvertModelToViewModelList(modelList);


            }
            catch (Exception)
            {
                throw;
            }
            var result = new PagedResult<CourseViewModel>
            {
               


            };
            return result;


        }
        


        public CourseViewModel GetCourseById(int id)
        {
            var model = _unitOfWork.GenericRepository<Course>().GetById(id);
            var vm = new CourseViewModel();
            return vm;
        }

        public void InsertCourse(CourseViewModel model)
        {
           
            var vm = new CourseViewModel().ConvertViewModel(model);
            _unitOfWork.GenericRepository<Course>().Add(vm);
            _unitOfWork.Save();

        }

        public void UpdatedCourse(CourseViewModel model)
        {

            var course = new CourseViewModel().ConvertViewModel(model);
            var ModelById = _unitOfWork.GenericRepository<Course>().GetById(course.Id);
            ModelById.Name = course.Name;
            ModelById.Description = course.Description;
                

            _unitOfWork.GenericRepository<Course>().Update(ModelById);
            _unitOfWork.Save();
        }

        private List<CourseViewModel> ConvertModelToViewModelList(List<Course> modelList)
        {
            return modelList.Select(x => new CourseViewModel(x)).ToList();
        }
    }

    
}
