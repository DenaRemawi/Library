using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    [Table("Categories")]
    public class Category
    {
        public int ID { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public List<Book> books { get; set; }

    }
}
