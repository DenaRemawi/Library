using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
    public class Categoryservice:ICategoryservice
    {
        BooksContext context;
        public Categoryservice(BooksContext _context)
        {
            context = _context;
        }

        public List<Category> LoadCategory()
        {
            List<Category> lc = context.categories.ToList();
            return lc;
        }
        public void Insert(Category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }
      
        public void Deletee(int id)
        {
            Category cate = context.categories.Find(id);
            context.categories.Remove(cate);
            context.SaveChanges();
        }

    }
}
