using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;


namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public object GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }

            _productDal.Add(product);
        }

        public void ProductUpdate(Category p)
        {
            throw new NotImplementedException();
        }

        public void ProductUpdate(Product p)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            
            _productDal.Update(product);
        }


        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException e)
            {

                throw new Exception("Silme Gerçekleşemedi");

            }
            
        }

       
        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        public object GetAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        object IProductService.GetAll()
        {
           return _productDal.GetAll();
        }
    }
    }
    


  

