using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;

namespace NetCoreMVCLab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book moder= new Book();
            return View(moder);

        }
        public IActionResult Edit(int Id)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book moder = book.GetBookById(Id);
            return View(moder);

        }
    }
}
