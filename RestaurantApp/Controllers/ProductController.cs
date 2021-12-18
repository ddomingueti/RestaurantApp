using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
