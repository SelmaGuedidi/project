using Microsoft.AspNetCore.Mvc;

namespace Magasin.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Vendor()
        {
            return View();
        }
    }
}
