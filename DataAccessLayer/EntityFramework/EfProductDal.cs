using DataAccessLayer.Abstrack;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    internal class EfProductDal : GenericRepository<Product>, IProductDal
    {

    }
}
