using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
   public interface INationalservice
    {
        List<National> loadnational();
    }
}
