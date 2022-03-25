using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class VmAuthor
    {

        public Author author { set; get; }

       public List <National> nat { set; get; }
    }
}
