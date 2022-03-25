using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BooksContext: IdentityDbContext<AppUser>
    {
        IConfiguration configuration;

        public BooksContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        public DbSet<Category> categories { get; set; }
        public DbSet<Author> authors { get; set; }

        public DbSet<Book> books { get; set; }


        public DbSet<National> national { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost; initial catalog=Group_Book; integrated security=true ");
            base.OnConfiguring(optionsBuilder);
        }


    }
}

