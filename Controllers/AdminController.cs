/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCRM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCRM.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        public AdminController(UserManager<AppUser> usrMgr)
        {
            userManager = usrMgr;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create (User user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = user.Name,
                    EmailTokenProvider = user.Email
                };
                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                    return RedirectToAction("Index");
            }
        }
    }
}
*/