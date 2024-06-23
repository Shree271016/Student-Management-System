using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Student.Models;
using Student.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IdentityUser = Student.Models.IdentityUser;

namespace Student.Utilities
{
    public class DbInitializer : IDbInitializer
    {

        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager, 
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Any())
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception )
            {
                // Log the exception (ex) if needed
                throw;
            }

            if (!_roleManager.RoleExistsAsync(WebSiteRole.WebSite_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_Employee)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_student)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_Teacher)).GetAwaiter().GetResult();


                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "Admin@abc.com"
                }, "Admin@123");
                var appuser = _context.ApplicationUsers.Where(x => x.Email == "Admin@abc.com").FirstOrDefault();

                if (appuser != null)
                {

                    _userManager.AddToRoleAsync(appuser, WebSiteRole.WebSite_Admin).GetAwaiter().GetResult();
                }


            }
        }
    }
}
