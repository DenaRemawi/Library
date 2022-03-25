using Library.Data;
using Library.Models;
using Library.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Authorize(Roles = "Admin")]

    public class AuthorController : Controller
    {

        /*   public IActionResult Index()
           {

               return View("Author_view");
           }
           public IActionResult NewList()
           {

               return View("list");
           }

       }
   }*/
        IConfiguration Configuration;
        INationalservice inationalservice;
        IAuthorservice iAuthorservice;
        public AuthorController(IConfiguration configuration, INationalservice nationalservice, IAuthorservice authorservice)
        {
            Configuration = configuration;
            inationalservice = nationalservice;
            iAuthorservice = authorservice;
        }
        /*  public IActionResult Index()
          {

              return View("Author_view");
          }*/
        public IActionResult NewList(VmAuthor Vm)
        {
            List<National> NA = inationalservice.loadnational();
            Vm.nat = NA;
            return View("list", Vm);
        }
        public IActionResult NewListA(VmAuthor Vm)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), Configuration["Filepath"], Vm.author.Image.FileName);

            Vm.author.Image.CopyTo(new FileStream(path, FileMode.Create));

            Vm.author.Path = "http://localhost/Library/" + Vm.author.Image.FileName;

            List<National> NA = inationalservice.loadnational();

            if (ModelState.IsValid == true)
            {

                iAuthorservice.insert(Vm.author);
            }

            Vm.nat = NA;
            return View("list", Vm);
        }

        public IActionResult Index()
        {

            List<Author> authors = iAuthorservice.loadAuthor();
            return View("Author_view", authors);
        }
        public IActionResult Deletee(int id)
        {
            iAuthorservice.Deletee(id);

            List<Author> authors = iAuthorservice.loadAuthor();
            return View("Author_view", authors);
        }




    }
}
