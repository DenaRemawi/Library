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

    public class BookController : Controller
    {
        IConfiguration configuration;
        IBookservice bookService;
        ICategoryservice categoryService;
        IAuthorservice authorService;

        public BookController(IConfiguration _configuration, IBookservice _bookService, ICategoryservice _categoryService, IAuthorservice _authorService)
        {
            configuration = _configuration;
            bookService = _bookService;
            categoryService = _categoryService;
            authorService = _authorService;
        }

        public IActionResult New(VBook Vb)
        {
            List<Category> c = categoryService.LoadCategory();
            List<Author> A = authorService.loadAuthor();
            Vb.cate = c;
            Vb.authors = A;
            return View("listBook", Vb);

        }
        public IActionResult SAVEBOOK(VBook Vb)
        {
            List<Category> c = categoryService.LoadCategory();
            List<Author> A = authorService.loadAuthor();

            string path = Path.Combine(Directory.GetCurrentDirectory(), configuration["FilePath"], Vb.book.Cover.FileName);
            Vb.book.Cover.CopyTo(new FileStream(path, FileMode.Create));
            Vb.book.Path = "http://localhost/Library/" + Vb.book.Cover.FileName;

            bookService.insert(Vb.book);
            Vb.cate = c;
            Vb.authors = A;
            return View("listBook", Vb);
        }
        public IActionResult Index()
        {

            List<Book> b = bookService.loadBook();
            return View("Book_View", b);
        }

        public IActionResult Deletee(int id)
        {
            bookService.Deletee(id);

            List<Book> boo = bookService.loadBook();
            return View("Book_View", boo);
        }

    }
}
