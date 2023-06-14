using CodingWiki_DataAccess.FluentConfig;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<MainBookDetails> MainBookDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookAuthorMap> BookAuthors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        //rename to Fluent_BookDetails
        public DbSet<Fluent_BookDetail> Fluent_BookDetail { get; set; }
        public DbSet<Fluent_Book> Fluent_Book { get; set; }
        public DbSet<Fluent_Author> Fluent_Author { get; set; }
        public DbSet<Fluent_Publisher> Fluent_Publisher { get; set; }
        public DbSet<Fluent_BookAuthorMap> Fluent_BookAuthors { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           // options.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CodingWiki;Data Source=PT-9XFFTQ3\\SQLSERVER2022;TrustServerCertificate=True")
           //     .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name } , LogLevel.Information );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });

            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorMapConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());

          //modelBuilder.Entity<Book>().HasData(
          //    new Book { Book_Id = 1, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m, Publisher_Id = 1 },
          //    new Book { Book_Id = 2, Title = "Fortune of Time", ISBN = "123B123", Price = 11.99m, Publisher_Id = 1 }
          //    );

            var bookList = new Book[]
            {
                new Book { Book_Id = 1, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m, Publisher_Id = 1 },
                new Book { Book_Id = 2, Title = "Fortune of Time", ISBN = "123B123", Price = 11.99m, Publisher_Id = 1 },
                new Book { Book_Id = 3, Title = "Fake Sunday", ISBN = "123B1234", Price = 12.99m,  Publisher_Id = 2 },
                new Book { Book_Id = 4, Title = "Cookie Jar", ISBN = "123B12345", Price = 13.99m,  Publisher_Id = 3 },
                new Book { Book_Id = 5, Title = "Cloudy Forest", ISBN = "123B123456", Price = 14.99m,  Publisher_Id = 3 }
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Publisher_Id = 1, Name = "Pub 1 Jimmy", Location = "Chicago"},
                new Publisher { Publisher_Id = 2, Name = "Pub 2 John", Location = "New York"},
                new Publisher { Publisher_Id = 3, Name = "Pub 3 Ben", Location = "Hawaii" }
                );

            modelBuilder.Entity<MainBookDetails>().HasNoKey().ToView("GetOnlyBookDetails");
        }
    }
}
