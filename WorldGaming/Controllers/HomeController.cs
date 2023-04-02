using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldGaming.Models;
using WorldGaming.Models.Data;
using System.Diagnostics;

namespace WorldGaming.Controllers
{
    public class HomeController : Controller
    {


        // 

        private ApplicationDbContext _context; // عشان يقرا من ال دب كونتكست
        // وارجع اعرفها في دالة البناء فالبارميتر 

        public HomeController(ApplicationDbContext context)
        {


            this._context = context;

        }
      

       

        public IActionResult Index()
        {

            var products = _context.products.ToList(); // قراية البيانات من جدول البرودكت وخزنتها فالبرودكت

           

            return View(products);
        }

        public IActionResult Invoice(int id)
        {
            var productDet = _context.productsDet.Include(pd => pd.Products).FirstOrDefault(pd => pd.Products.Id == id);
            return View(productDet);
        }

        public IActionResult Det(int id)
        {
            var productDet = _context.productsDet.Include(pd => pd.Products).FirstOrDefault(pd => pd.Products.Id == id);
            return View(productDet);
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
    }
}