using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateOnly Date {  get; set; } 
        public bool Status { get; set; }
        public String Remark { get; set; }
        public ApplicationUser Student { get; set; }
    }
}
