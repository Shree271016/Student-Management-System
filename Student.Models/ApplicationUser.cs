using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateOnly DOB {  get; set; }
        public DateOnly DateOfJoin { get; set; }    
        public string MobileNo { get; set; }    
        public Boolean Status { get; set; } 
        public DateTime LastLoginDate { get; set; }
        ///public string LastLoginIp { get; set; }

    }
}
