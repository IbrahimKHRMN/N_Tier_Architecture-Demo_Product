using DataAccessLayer.Abstrack;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class CategoryDal : ICategoryDal
    {
        Context c = new Context();
        public void Delete(Category p)
        {
            c.Categories.Remove(p);
        }

        public List<Category> GetList()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category p)
        {
            c.Categories.Add(p);
        }

        public void Update(Category p)
        {
            c.Categories.Update(p);
        }
    }
}
