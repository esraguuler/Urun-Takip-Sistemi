using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController (ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
       
        public ActionResult Index()
        {
            var result = _categoryService.GetAll(x => true);

            var model = new CategoryViewModel()
            {
               
            };
            return View(model);

        }
    }
}