using Microsoft.AspNetCore.Mvc;
using Mission11_Edgerton.Models;
using Mission11_Edgerton.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Edgerton.Controllers
{
    public class HomeController : Controller
    {
        private IAmazonRepository _repo;

        public HomeController(IAmazonRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var output = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
                
            return View(output);
        }
    }
}
