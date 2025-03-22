using Microsoft.AspNetCore.Mvc;
using Recipe_Management.Model;
using Recipe_Management.Services;

namespace Recipe_Management.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class ItemController : Controller
    {
        private readonly IitemService _itemService;
        public ItemController(IitemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("GetItem")]
        public IActionResult GetItem(int id)
        {
            return Ok(_itemService.GetItem(id));
        }

        [HttpGet("GetAllItems")]
        public IActionResult GetAllItems()
        {
            return Ok(_itemService.GetItems());
        }

        [HttpPost("CreateItem")]
        public IActionResult Create(Item item)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model is invalid");

            try
            {
                _itemService.CreateItem(item);
                return Ok("Item Created");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DeleteItem")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _itemService.DeleteItem(Id);
                return Ok("Item Removed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("UpdateItem")]
        public IActionResult Update(Item item)
        {
            try
            {
                _itemService.UpdateItem(item);
                return Ok("Item Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
