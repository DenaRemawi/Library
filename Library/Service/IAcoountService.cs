using Library.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
  public  interface IAcoountService
    {
        Task<IdentityResult> Create(SignupModel model);

        Task<SignInResult> SignIn(SignInModel model);

        Task<IdentityResult> AddRole(RoleModel model);

        List<IdentityRole> GetRole();
        Task SignOut();
    }
}
