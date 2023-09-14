using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entitities.Concrete;

namespace Northwind.DataAccess.Abstract
{
    public interface IAboutDal
    {
        void Insert(About about);
        void Update(About about);
    }
}
