using Library.Models;
using Library.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AccountController : Controller
    {
        IAcoountService iaccountService;
        IConfiguration Configuration;


        public AccountController(IAcoountService _iaccountService, IConfiguration configuration)
        {
            iaccountService = _iaccountService;
            Configuration = configuration;


        }

        public IActionResult Index()
        {
            vmSignUp vm = new vmSignUp();
            vm.liRole = iaccountService.GetRole();
            return View("SignUp", vm);
        }

        public async Task<IActionResult> SignUp(vmSignUp model)
        {
            vmSignUp vm = new vmSignUp();
            vm.liRole = iaccountService.GetRole();
            var result = await iaccountService.Create(model.signUp);
            return View("SignUp", vm);
        }

        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        public async Task<IActionResult> Login(SignInModel model)
        {
            var result = await iaccountService.SignIn(model);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "DashBoard");
            }
            else
            {
                ViewData["ErrorMessage"] = "Invalid Username or Password";
                return View("SignIn");
            }
        }


        public IActionResult Role()
        {
            return View("NewRole");
        }

        public async Task<IActionResult> NewRole(RoleModel model)
        {
            var result = await iaccountService.AddRole(model);

            return View("NewRole");
        }

        public IActionResult AccessDenied()
        {
            return View();

        }
        public async Task<IActionResult> Logout()
        {
            await iaccountService.SignOut();
            return View("SignIn");
        }


    }
}

