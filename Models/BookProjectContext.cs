using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookProject.Models
{
    public class BookProjectContext : DbContext
    {
        public BookProjectContext()
        {
        }

        public BookProjectContext(DbContextOptions<BookProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}
