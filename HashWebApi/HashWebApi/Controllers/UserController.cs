using AutoMapper;
using HashWebApi.Entities;
using HashWebApi.ModelsDTO;
using Microsoft.AspNetCore.Mvc;

namespace HashWebApi.Controllers
{
	public interface IUserService
	{
		IActionResult GetUser(string? userId);
		IActionResult CreateUser(User? user);
		IActionResult UpdateUser(string? userId);
		IActionResult DeleteUser(string? userId);
	}

	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IUserService m_service;
		private readonly ILogger<UserController> m_logger;
		private readonly IMapper m_mapper;

		public UserController(IUserService mService, ILogger<UserController> mLogger, IMapper mMapper)
		{
			m_service = mService;
			m_logger = mLogger;
			m_mapper = mMapper;
		}

		[HttpGet]
		[Route("{userId}")]
		public IActionResult GetUser([FromRoute] string? userId)
		{
			if (userId is null) 
				return BadRequest($"{nameof(userId)} can't be null.");

			return Ok();
		}

		/// <summary>
		/// Creates user.
		/// </summary>
		/// <param name="user">User params.</param>
		/// <returns>Path and copy to created resource.</returns>
		[HttpPost]
		[Route("")]
		public IActionResult CreateUser([FromRoute] UserDTO? user)
		{
			if (ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Created("", user);
		}

		[HttpPatch]
		[Route("{userId}")]
		public IActionResult UpdateUser([FromRoute] string? userId)
		{
			if (userId is null)
				return BadRequest($"{nameof(userId)} can't be null.");

			return Ok();
		}

		[HttpDelete]
		[Route("{userId}")]
		public IActionResult DeleteUser([FromRoute] string? userId)
		{
			if (userId is null)
				return BadRequest($"{nameof(userId)} can't be null.");

			return Ok();
		}
	}
}
