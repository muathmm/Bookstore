using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Bookstore.data
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId=1, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 15.99m, Genre = "Fiction" },
                new Book { BookId = 2, Title = "1984", Author = "George Orwell", Price = 12.99m, Genre = "Dystopian" },
                new Book { BookId = 3,  Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m, Genre = "Classic" },
                new Book { BookId = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 25.99m, Genre = "Fantasy" }
            );
        }
    }
}
