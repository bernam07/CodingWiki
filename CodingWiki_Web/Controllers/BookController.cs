using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using CodingWiki_Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_Web.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Book> objList = _db.Books.Includ(u=>u.Publisher).ToList();
            //foreach(var obj in objList)
            //{
                //least efficient 
                //obj.Publisher = _db.Publishers.Find(obj.Publisher_Id);
                
                //most efficient 
                //db.Entry(obj).Reference(u=>u.Publisher).Load();
            //}
            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            BookVM obj = new();

            obj.PublisherList = _db.Publishers.Select(i=> new SelectListItem
            {
                Text = i.Name,
                Value=i.Publisher_Id.ToString()
            });

            if (id == null || id == 0)
            {
                //create
                return View(obj);
            }
            //edit
            obj.Book = _db.Books.FirstOrDefault(u => u.Book_Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Upsert(BookVM obj)
        {
                if (obj.Book.Book_Id == 0)
                {
                    //create
                    await _db.Books.AddAsync(obj.Book);
                }
                else
                {
                    //update
                    _db.Books.Update(obj.Book);
                }
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                //create
                return NotFound();
            }
            BookDetail obj = new();

            
            //edit
            obj = _db.BookDetails.Include(u=>u.Book).FirstOrDefault(u => u.Book_Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Details(BookDetail obj)
        {
            if (obj.Book.BookDetail.BookDetail_Id == 0)
            {
                //create
                await _db.BookDetails.AddAsync(obj);
            }
            else
            {
                //update
                _db.BookDetails.Update(obj);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
        public async Task<IActionResult> Playground()
        {
            //updating related data
            var bookdetails1 = _db.BookDetails.Include(b=>b.Book).FirstOrDefault(b=>b.BookDetail_Id == 5);
            bookdetails1.NumberOfChapters = 2222;
            bookdetails1.Book.Price = 222;
            _db.BookDetails.Update(bookdetails1);
            _db.SaveChanges();

            var bookdetails2 = _db.BookDetails.Include(b=>b.Book).FirstOrDefault(b=>b.BookDetail_Id == 5);
            bookdetails2.NumberOfChapters = 1111;
            bookdetails2.Book.Price = 111;
            _db.BookDetails.Attach(bookdetails2);
            _db.SaveChanges();


            // IEnumerable<Book> BookList1 = _db.Books;
            // var FilteredBook1 = BookList1.Where(b=>b.Price > 50).ToList();

            // IEnumerable<Book> BookList2 = _db.Books;
            // var FilteredBook2 = BookList2.Where(b=>b.Price > 50).ToList();
            // var bookTemp = _db.Books.FirstOrDefault();
            // bookTemp.Price = 100;

            // var bookCollection = _db.Books;
            // decimal totalPrice = 0;

            // foreach(var book in bookCollection)
            // {
            //     totalPrice += book.Price;
            // }

            // var bookList = _db.Books.ToList();
            // foreach (var book in bookList)
            // {
            //     totalPrice += book.Price;
            // }

            // var bookCollection2 = _db.Books;
            // var bookCount1 = bookCollection2.Count();

            // var bookCount2 = _db.Books.Count();
            return RedirectToAction(nameof(Index));
        }
    }
}
