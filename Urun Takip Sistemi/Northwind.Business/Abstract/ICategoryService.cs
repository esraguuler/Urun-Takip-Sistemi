using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetAll(object Entity);
        void CategoryUpdate(Category category);

        Category GetByID(int id);
        void CategoryDelete(Category category);
        object GetAll(Func<object, bool> Entity);
        List<Category> GetAll();
    }
}
