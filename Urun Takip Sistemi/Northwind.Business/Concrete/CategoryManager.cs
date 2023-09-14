using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public object GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }
        public List<Category> GetAll(int id)
        {
            return _categoryDal.GetAll();
        }

        List<Category> ICategoryService.GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        public object GetAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
