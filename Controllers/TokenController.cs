using ApiTokenDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTokenDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TokenController : ControllerBase
{
	private readonly IJwtTokenManager _jwtTokenManager;

	public TokenController(IJwtTokenManager jwtTokenManager)
	{
		_jwtTokenManager = jwtTokenManager;
	}

	[HttpPost("Authenticate")]
	public IActionResult Authenticate([FromBody] UserCredential credential)
	{
		var token = _jwtTokenManager.Authenticate(credential.Username, credential.Password);

		if (string.IsNullOrEmpty(token)) return Unauthorized();

		return Ok(token);

	}
}
