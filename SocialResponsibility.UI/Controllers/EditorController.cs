using SocialResponsibility.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialResponsibility.UI.Controllers
{
    public class EditorController : Controller
    {
        // GET: Editor
        private DataService DataService;

        public EditorController()
        {
            DataService = new DataService();
        }


        public ActionResult AddProject()
        {
            DataService.UnitOfWork.Projects.Insert(new Model.Entities.Project
            {

            });
            return View();
        }
    }
}