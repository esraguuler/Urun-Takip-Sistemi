using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entitities.Concrete;

namespace Northwind.Business.Abstract
{
   public interface IAboutService
    {
        List<About> GetAll(object Entity);
        void AboutUpdate(About about);
        void AboutAdd(About about);

        About GetByID(int id);

        object GetAll(Func<object, bool> Entity);
        List<About> GetAll();
    }
}
