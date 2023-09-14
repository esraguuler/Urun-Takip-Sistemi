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
    public class AboutManager: IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager (IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About about)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll(object Entity)
        {
            throw new NotImplementedException();
        }

        public object GetAll(Func<object, bool> Entity)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
