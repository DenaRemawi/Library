using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class AppUser: IdentityUser
    {
        public string YourName { get; set; }

    }
}
