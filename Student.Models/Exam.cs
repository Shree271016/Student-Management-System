using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int ExamTypeId { get; set; }
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
    }
}
