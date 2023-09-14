using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(object p);
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        object GetAll(Func<object, bool> p);
        object GetAll();
    }
}
