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
    public class ProductDal : IProductDal
    {
        Context c = new Context();
        public void Delete(Product p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public List<Product> GetList()
        {
            return c.Products.ToList();
        }

        public void Insert(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
        }

        public void Update(Product p)
        {
            c.Products.Update(p);
            c.SaveChanges();
        }
    }
}
