using Microsoft.EntityFrameworkCore;
using System;
using Bookish.Models;

namespace Bookish
{
    public class BookishContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<CheckedOutBook> CheckedOutBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LocalHost;Database=Bookish;Trusted_Connection=True;");
        }
    }
}