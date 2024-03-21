using Microsoft.AspNetCore.Mvc;
using Mission11_FinalLaurenLago.Models;
using Mission11_FinalLaurenLago.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_FinalLaurenLago.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new ProjecstListViewModel
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



            return View(blah);
        }
   
    }
}
