using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class vmSignUp
    {
        public SignupModel signUp { get; set; }
        public List<IdentityRole> liRole { get; set; }
    }
}
