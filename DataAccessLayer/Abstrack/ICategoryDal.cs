using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrack
{
    public interface ICategoryDal
    {
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);
        List<Category> GetList();
    }
}
