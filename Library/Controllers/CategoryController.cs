using Library.Data;
using Library.Models;
using Library.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {

        ICategoryservice categoryService;
            public CategoryController(ICategoryservice _categoryService)
            {
                categoryService = _categoryService;
            }
            public IActionResult New(Category cate)
               
            {
              
                return View("NewCa");
            }
            public IActionResult Save(Category c)
            {
         

                categoryService.Insert(c);
            
                return View("NewCa", c);


        }

        public IActionResult Index()
        {

            List<Category> caaa = categoryService.LoadCategory();
            return View("Category_View", caaa);
        }

        public IActionResult Deletee(int Id)
            {

                categoryService.Deletee(Id);
            List<Category> caaa = categoryService.LoadCategory();
            return View("Category_View", caaa);
            }

     

        }
    }

