using SocialResponsibility.BLL.Service;
using SocialResponsibility.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SocialResponsibility.UI.Controllers
{
    public class FilterController : Controller
    {
        private DataService dataService;

        public FilterController()
        {
          dataService = new DataService();
        }
        //public ActionResult List(int? categoryId)
        //{
        //    List<Activity> model;
        //    if  (categoryId)

        //    //var model = new FilterListVm()
        //    //{

        //    //    Categories = dataService.UnitOfWork.Categories.Get()
        //    //};



        //    //var exps = new List<Expression<Func<Activity, bool>>>();

        //    //if (categoryId != null)
        //    //    exps.Add(x => x.CategoryId == categoryId);


        //    //model.Activities = dataService.UnitOfWork.Activities.FilterByAll(exps.ToArray());
        //    //model.categoryId = categoryId;


        //    return View();
        //}
        
        public ActionResult ListProjects(int? categoryId)
        {
            List<Project> model;
            if (categoryId==null)
            {
                model = dataService.UnitOfWork.Projects.GetEntities();
            }
            else
            {
                model = dataService.UnitOfWork.Projects.Get(x => x.CategoryId == categoryId).ToList();
            }
            return View(model);
        }

      
    }
}