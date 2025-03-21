using Microsoft.AspNetCore.Mvc;

namespace Recipe_Management.Controllers
{
    public class FoodController : Controller
    {
        [HttpGet("GetFood")]
        public IActionResult Get(int id)
        {
            return Ok(1);
        }

    }
}
