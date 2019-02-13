using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessFramework.Core.DataAccess;
using BusinessFramework.Northwind.Entities.Concrete;

namespace BusinessFramework.Northwind.DataAccess.Abstract
{
    interface IProductDal:IEntityRepository<Product>
    {
    }
}
