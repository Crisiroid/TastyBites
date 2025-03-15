using Microsoft.AspNetCore.Mvc;

namespace Recipe_Management.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
