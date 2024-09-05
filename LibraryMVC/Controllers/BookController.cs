using LibraryAPI.Models;
using LibraryMVC.Models;
using LibraryMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LibraryMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _bookService.GetAllBooks<APIResponseDTO>();
            List<Book> books = new List<Book>();

            if (response != null && response.IsSuccess)
            {
                books = JsonConvert.DeserializeObject<List<Book>>(Convert.ToString(response.Result));
            }
            return View(books);
        }

        //[HttpPost]
        public async Task<IActionResult> SearchForBooks(string searchKeyword)
        {
            var response = await _bookService.GetBookBySearch<APIResponseDTO>(searchKeyword);
            List<Book> books = new List<Book>();

            if (response != null && response.IsSuccess)
            {
                books = JsonConvert.DeserializeObject<List<Book>>(Convert.ToString(response.Result));
            }
            return View(books);
        }
    }
}
