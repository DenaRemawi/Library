using Library.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
    public class Authorservice :IAuthorservice
    {
        BooksContext context;
        public Authorservice(BooksContext _context)
        {
            context = _context;
        }
        public void insert(Author A)
        {
            context.authors.Add(A);
            context.SaveChanges();
        }
        public List<Author> loadAuthor()
        {
            List<Author> Au = context.authors.ToList();
            return Au;
        }
        public void Deletee(int id)
        {

          Author author = context.authors.Find(id);
            context.authors.Remove(author);
            context.SaveChanges();


        }
   

    }

}
