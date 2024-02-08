using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.Models.ReletionTables;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using CodeAcademy_Final_Project.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Backend_Final.Extensions;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Components;

namespace CodeAcademy_Final_Project.Areas.AdminArea.Controllers
{
    [Area(nameof(AdminArea))]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;
        public BookController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var book = _context.Book.ToList();

            return View(book);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(string? search)
        {
            List<Book> book = new();
            if (search == null) {
                book = _context.Book.ToList();
            }
            else
            {
                book = _context.Book.Where(b => b.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return View(book);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) { return View(); }
            var book = _context.Book.FirstOrDefault(b => b.Id == id);
            var bookAuthor = _context.BookAuthor.ToList();

            if (book == null || bookAuthor == null)
            {
                return NotFound();
            }
            foreach (var bookA in bookAuthor)
            {
                _context.BookAuthor.Remove(bookA);

            }
            _context.Book.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");




            public IActionResult Create()
            {
                ViewBag.Genres = _context.Genre.ToList();
                ViewBag.Author = _context.Author.ToList();
                ViewBag.Languages = _context.Languages.ToList();
                return View();
            }

            [HttpPost]
            [AutoValidateAntiforgeryToken]
            public IActionResult Create(CreateBookVM createBookVM, List<int> genreId, List<int> authorId, int languageId)
            {
                ViewBag.Genres = _context.Genre.ToList();
                ViewBag.Author = _context.Author.ToList();
                ViewBag.Languages = _context.Languages.ToList();
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Bosh xana saxlamaq olmaz!");
                }

                Book book = new();
                book.Name = createBookVM.Name;
                book.Price = createBookVM.Price;
                book.PageCount = createBookVM.PageCount;
                book.Width = createBookVM.Width;
                book.Length = createBookVM.Length;
                book.Height = createBookVM.Height;
                book.Description = createBookVM.Description;
                book.LanguageId = languageId;
                book.BTypeId = 1;
                if (!createBookVM.Photo.CheckImage())
                {
                    ModelState.AddModelError("Photo", "Yalniz shekil!"); ;
                    return View();
                }
                if (createBookVM.Photo.CheckSize(1000))
                {
                    ModelState.AddModelError("Photo", "Chox boyuk fayldir!"); ;
                    return View();
                }
                book.ImgUrl = createBookVM.Photo.SaveImage("images", _webHostEnvironment)[0];
                book.EBookId = null;
                book.ABookId = null;
                _context.Book.Add(book);
                foreach (var author in authorId)
                {

                    var existAuthor = _context.Author.FirstOrDefault(g => g.Id == author);
                    BookAuthor bookAuthor = new()
                    {
                        Author = existAuthor,
                        AuthorId = existAuthor.Id,
                        Book = book,
                    };

                    _context.BookAuthor.Add(bookAuthor);

                }
                foreach (var genre in genreId)
                {
                    var existGenre = _context.Genre.FirstOrDefault(g => g.Id == genre);
                    BookGenre bookGenre = new();
                    bookGenre.GenreId = genre;
                    bookGenre.Book = book;
                    _context.BookGenre.Add(bookGenre);



                    var category = new BookCategory();
                    category.Book = book;
                    category.CategoryId = existGenre.CategoryId;
                    _context.BookCategory.Add(category);


                }


                _context.SaveChanges();
                return RedirectToAction("CheckExcistence", book.Id);
            }
            public IActionResult CheckExcistence(int id)
            {
                var book = _context.Book.FirstOrDefault(b => b.Id == id);
                if (book == null)
                {

                    return NotFound();
                }
                CheckExcistenceVM check = new();
                check.BookId = id;
                check.EBookId = book.EBookId;
                check.ABookId = book.ABookId;
                return View(check);
            }
        }
    }
}
