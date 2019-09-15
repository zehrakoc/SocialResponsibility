using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SocialResponsibility.BLL.Service;
using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialResponsibility.UI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;

        public AdminController()
        {
            var userStore = new UserStore<AppUser>(new AppDbContext());
            userManager = new UserManager<AppUser>(userStore);
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}