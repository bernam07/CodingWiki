// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using(ApplicationDbContext context = new())
//{
//    context.Database.EnsureCreated();
//    if(context.Database.GetPendingMigrations().Count() > 0)
//    {
//        context.Database.Migrate();
//    }
//}

//GetAllBooks();
//AddBook();
//GetBook();
//UpdateBook();
//DeleteBook();

//void DeleteBook()
//{
//    using var context = new ApplicationDbContext();
//    var book = context.Books.Find(1003);
//    context.Books.Remove(book);
//    context.SaveChanges();
//}

//void UpdateBook()
//{
//    try
//    {
//        using var context = new ApplicationDbContext();
//        var books = context.Books.Where(u=>u.Publisher_Id==1);
//        // Console.WriteLine(book.Title + " - " + book.ISBN);
//        foreach(var book in books)
//        {
//            book.Price = 55.55m;
//        }
//        context.SaveChanges();
//    }
//    catch (Exception e)
//    {

//    }
//}

//void GetBook()
//{
//    try
//    {
//        using var context = new ApplicationDbContext();
//        var books = context.Books;
//        foreach (var book in books)
//        {
//            Console.WriteLine(book.Title + " - " + book.ISBN);
//        }
//        // Console.WriteLine(book.Title + " - " + book.ISBN);
//        //var book = context.Books.Find(1002);
//        //var books = context.Books.Skip(0).Take(2);
//        //var book = context.Books.Single(u=>u.Book_Id==1002);
//        //var book = context.Books.FirstOrDefault(u => u.Publisher_Id == 3);
//        //var book = context.Books.Where(u => u.ISBN.Contains("12"));
//        //var book = context.Books.Where(u => EF.Functions.Like(u.ISBN,"12%")).Max(u=>u.Price);
//        //var books = context.Books.OrderBy(u=>u.Title).ThenByDescending(u=>u.ISBN);    
//    }
//    catch (Exception e) 
//    {
        
//    }
//}

//void GetAllBooks()
//{
//    using var context = new ApplicationDbContext();
//    var books = context.Books.ToList();
//    foreach(var book in books)
//    {
//        Console.WriteLine(book.Title+ " - " + book.ISBN);
//    }
//}
//void AddBook()
//{
//    Book book = new() { Title="New EF Core Book", ISBN="121131", Price=10.93m};
//    using var context = new ApplicationDbContext();
//    var books = context.Books.Add(book);
//    context.SaveChanges();
//}