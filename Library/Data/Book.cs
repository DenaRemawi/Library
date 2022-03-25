using Library.Helper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    [Table("Books")]
    public class Book
    {
            public int ID { set; get; }

            [Required]
            public String Book_Title { set; get; }
        [Hyear]
        public DateTime Year { get; set; }

        public double Price { get; set; }


            [ForeignKey("category")]
            public int Category_ID { get; set; }
            public Category categori { get; set; }

            [ForeignKey("AuthorID")]
            public int Author_ID { get; set; }
            public Author author { get; set; }

            public String Path { set; get; }
            [NotMapped]
            public IFormFile Cover { set; get; }
  

        public int Stock { get; set; }
        

    }
}
