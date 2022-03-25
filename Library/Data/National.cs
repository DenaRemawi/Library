using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    [Table("Nationality")]
    public class National
    {
      
      
            public int ID { get; set; }

            [Required]
            public String Name { get; set; }

            public List<Author> author { get; set; }
       }
    }

