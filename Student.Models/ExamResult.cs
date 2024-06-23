using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class ExamResult
    {
        public int Id { get; set; }
        public ApplicationUser Student { get; set; }
        public Exam Exam { get; set; }  
        public Course Course { get; set; }
        public string Marks { get; set; }
      
    }
}
