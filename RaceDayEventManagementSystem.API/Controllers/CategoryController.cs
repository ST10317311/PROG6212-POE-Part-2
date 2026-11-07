using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RaceDayEventManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
           var categories = DbContext.CategoryModel.ToList();
           return Ok(categories);
        }
    }
}
