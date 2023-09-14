using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.WebUI.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Categories = new List<Category>();
        }

        public List<Category> Categories { get; set; }
    }
}