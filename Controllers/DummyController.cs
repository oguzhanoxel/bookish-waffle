using ApiTokenDemo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiTokenDemo.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class DummyController : ControllerBase
{
	[HttpGet]
	public IActionResult GetHiIamElfo()
	{
		var token = HttpContext.GetTokenAsync("access_token").Result;
		return Ok("Hi I am Elfo.");
	}
}
