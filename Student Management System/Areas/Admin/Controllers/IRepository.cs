
namespace Student_Management_System.Areas.Admin.Controllers
{
    internal interface IRepository<T>
    {
        Task<dynamic> GetAllAsync(Func<object, bool> value);
    }
}