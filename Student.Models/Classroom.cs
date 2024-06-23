using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Section { get; set; }
        public string Remark { get; set; }

        public bool Status { get; set; }
      
        public ApplicationUser Teacher { get; set; }
    }
}
