using Northwind.Business.Concrete;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.WebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

       
        public ActionResult Index()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            return View(categoryvalue);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }  

        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            cm.CategoryDelete(categoryvalue);

            return RedirectToAction("Index");
        }
    }
}