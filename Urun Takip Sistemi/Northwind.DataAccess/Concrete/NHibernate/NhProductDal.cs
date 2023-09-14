using Northwind.DataAccess.Abstract;
using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {

        

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
            new Product {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Laptop",
                QuantityPerUnit = "1 in a box",
                UnitPrice = 300000,
                UnitsInStock = 11 }
        };
            return products;
        }

        public void Update(Product product)
    {
            

    }
}
}
