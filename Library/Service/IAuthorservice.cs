using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
 public   interface IAuthorservice
    {
        List<Author> loadAuthor();
        void insert(Author A);
        void Deletee(int id);


    }
}
