using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
    public class Bookservice : IBookservice
    {
        BooksContext context;
        public Bookservice(BooksContext _context)
        {
            context = _context;
        }

        public List<Book> loadBook()
        {
            List<Book> b = context.books.ToList();

            return b;
        }

        public void insert(Book book)
        {
            context.books.Add(book);
            context.SaveChanges();
        }
        public void Deletee(int id)
        {

            Book boo = context.books.Find(id);
            context.books.Remove(boo);
            context.SaveChanges();


        }
    }
}
