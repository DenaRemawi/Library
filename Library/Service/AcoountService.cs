using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
    public class AcoountService:IAcoountService
    {

        UserManager<AppUser> userManager;
        SignInManager<AppUser> signInManager;
        RoleManager<IdentityRole> roleManager;

        public AcoountService(UserManager<AppUser> _UserManager,
            SignInManager<AppUser> _signInManager,
            RoleManager<IdentityRole> _roleManager)

        {
            userManager = _UserManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        public async Task<IdentityResult> Create(SignupModel model)
        {
            AppUser user = new AppUser();
            user.Email = model.Email;
            //user.PasswordHash = model.Password;
            user.YourName = model.Name;
            user.UserName = model.UserName;

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var role = await roleManager.FindByIdAsync(model.Role_Id);

                result = await userManager.AddToRoleAsync(user, role.Name);

            }

            return result;
        }

        public async Task<SignInResult> SignIn(SignInModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.rememberMe, false);
            return result;
        }

        public async Task<IdentityResult> AddRole(RoleModel model)
        {
            IdentityRole role = new IdentityRole();
            role.Name = model.Name;

            var result = await roleManager.CreateAsync(role);
            return result;
        }

        public List<IdentityRole> GetRole()
        {
            List<IdentityRole> liRole = roleManager.Roles.ToList();
            return liRole;
        }
        public async Task SignOut()
        {
            await signInManager.SignOutAsync();
        }

    }
}

    
