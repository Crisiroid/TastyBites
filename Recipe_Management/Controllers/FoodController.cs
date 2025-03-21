using Microsoft.AspNetCore.Mvc;
using Recipe_Management.Model;
using Recipe_Management.Services;

namespace Recipe_Management.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet("GetFood")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_foodService.GetFood(id));

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost("CreateFood")]
        public IActionResult Create(Food food)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model isn't Valid");
            try
            {
                _foodService.CreateFood(food);
                return Ok("Recipe Added");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
