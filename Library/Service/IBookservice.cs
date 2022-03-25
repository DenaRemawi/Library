using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
  public  interface IBookservice
    {
        public List<Book> loadBook();
        void insert(Book book);
        void Deletee(int id);


    }
}
