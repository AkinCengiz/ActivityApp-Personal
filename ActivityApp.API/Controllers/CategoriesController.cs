using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActivityApp.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
	[HttpGet]
	public IActionResult GetCategories()
	{

		return Ok("Categories");
	}
}
