using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    [Table("Authors")]
    public class Author
    {
       
            public int ID { set; get; }

            [Required]
            public String FirstName { set; get; }

            [Required]
            public String LastName { set; get; }

            public String Path { set; get; }

            [NotMapped]
            public IFormFile Image { set; get; }

            [ForeignKey("National")]
            public int NationalityID { get; set; }
            public National national { get; set; }

            public List<Book> books { get; set; }

      
    }
}