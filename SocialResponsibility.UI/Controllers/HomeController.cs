using SocialResponsibility.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialResponsibility.UI.Controllers
{
    public class HomeController : Controller
    {
        private DataService DataService;

        public HomeController()
        {
            DataService = new DataService();
        }
        public ActionResult Index()
        {
            var model = DataService.UnitOfWork.Projects.Get();
            return View(model);
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Giris()
        {
            return View();
        }
        public ActionResult CategoryPartial()
        {
            var model = DataService.UnitOfWork.Categories.Get();
            return View(model);
        }
        public ActionResult Detay(int id)
        {
            var model = DataService.UnitOfWork.Projects.GetById(id);
            return View(model);
        }
    }
}