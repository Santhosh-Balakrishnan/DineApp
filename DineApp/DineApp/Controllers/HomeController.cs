using DineApp.Models;
using DineApp.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DineApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBillDeskService _billDeskService;
        public BillDesk billDesk;
        public HomeController(ILogger<HomeController> logger, IBillDeskService billDeskService)
        {
            _logger = logger;
            _billDeskService = billDeskService;
            billDesk = _billDeskService.BillDesk;
        }

        public IActionResult Index()
        {
            return View(billDesk);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddOrder(int tableNo)
        {
            var value = billDesk.Tables.FirstOrDefault(t => t.No == tableNo);
            if(value!=null)
            {
                if (value.TableState == TableState.Available)
                {
                    value.TableState = TableState.Ordered;
                    billDesk.Orders.Add(new Order(value));
                }
            }
            return RedirectToAction("Index");
        }
    }
}