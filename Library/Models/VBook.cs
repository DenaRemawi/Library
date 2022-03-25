using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class VBook
    {
        public Book book { get; set; }
        public List<Author> authors{ get; set; }
        public List<Category> cate { get; set; }
       // public Category cate { get; set; }


    }
}
