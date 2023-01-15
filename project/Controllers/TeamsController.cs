using Magasin.Data;
using Magasin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Magasin.Controllers
{
    public class TeamsController : Controller
    {
       private Unit UnitOfWork;
        public TeamsController()
        {
            this.UnitOfWork = new Unit();
        }
        public IActionResult Index()
        { 
            return View();
        }
        
    }
}
