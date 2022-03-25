using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
    public class Nationalservice : INationalservice
    {
        BooksContext context;
        public Nationalservice(BooksContext _context)
        {
            context = _context;
        }
        public List<National> loadnational()
        {
            List<National> Na = context.national.ToList();

            return Na;
        }
    }
}
