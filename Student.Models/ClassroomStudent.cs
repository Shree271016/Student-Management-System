using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class ClassroomStudent
    {
        public int Id { get; set; } 
        public ApplicationUser Student { get; set; }
        public Classroom Classroom { get; set; }
    }
}
