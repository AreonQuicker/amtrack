using System.Collections.Generic;
using System.Linq;
using Amtrack.Services.Users;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Amtrack.API.Controllers
{
	[Route("api/[controller]")]
	public class UsersController : Controller
	{
		private IUsersController _usersController;
		private ILogger<UsersController> _logger;
		private IUrlHelper _urlHelper;

		public UsersController(IUsersController usersController,
		  ILogger<UsersController> logger,
		  IUrlHelper urlHelper,
		  IMemoryCache memoryCache)
		{
			_logger = logger;
			_usersController = usersController;
			_urlHelper = urlHelper;
		}

		[HttpGet("ping", Name = "ping")]
		[ResponseCache(Duration = 30, Location = ResponseCacheLocation.Any)]
		public IActionResult Ping()
		{
			return Ok("PING");
		}

		[HttpGet("all", Name = "GetAllUsers")]
		[ResponseCache(Duration = 30, Location = ResponseCacheLocation.Any)]
		public IActionResult GetAllUsers()
		{
			var allUsersFromDb = _usersController.GetAllUsers().ToList();

			var allUsersVO = Mapper.Map<IEnumerable<Amtrack.ValueObjects.Users.UserVO>>(allUsersFromDb);

			return Ok(allUsersVO);
		}
	}
}