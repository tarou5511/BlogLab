using BlogLab.Models.Account;
using BlogLab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogLab.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountContoller : ControllerBase
	{
		private readonly ITokenService _tokenService;
		private readonly UserManager<ApplicationUserIdentity> _userManager;
		private readonly SignInManager<ApplicationUserIdentity> _signInManager;

		public AccountContoller(ITokenService tokenService, UserManager<ApplicationUserIdentity> userManager, SignInManager<ApplicationUserIdentity> signInManager)
		{
			_tokenService = tokenService;
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpPost("register")]
		public async Task<ActionResult<ApplicationUser>> Register(ApplicationUserCreate applicationUserCreate)
		{
			var applicationUserIdentity = new ApplicationUserIdentity
			{
				UserName = applicationUserCreate.Username,
				Email = applicationUserCreate.Email,
				Fullname = applicationUserCreate.Fullname
			};

			var result = await _userManager.CreateAsync(applicationUserIdentity, applicationUserCreate.Password);

			if (result.Succeeded)
			{
				ApplicationUser applicationUser = new ApplicationUser()
				{
					ApplicationUserId = applicationUserIdentity.ApplicationUserId,
					Username = applicationUserIdentity.UserName,
					Email = applicationUserIdentity.Email,
					Fullname = applicationUserIdentity.Fullname,
					Token = _tokenService.CreateToken(applicationUserIdentity)
				};

				return Ok(applicationUser);
			}

			return BadRequest(result.Errors);
		}

		[HttpPost("login")]
		public async Task<ActionResult<ApplicationUser>> Login(ApplicationUserLogin applicationUserLogin)
		{
			var applicationUserIdentity = await _userManager.FindByNameAsync(applicationUserLogin.Username);

			if (applicationUserIdentity != null)
			{
				var result = await _signInManager.CheckPasswordSignInAsync(
					applicationUserIdentity,
					applicationUserLogin.Password,
					false
					);

				if (result.Succeeded)
				{
					ApplicationUser applicationUser = new ApplicationUser()
					{
						ApplicationUserId = applicationUserIdentity.ApplicationUserId,
						Username = applicationUserIdentity.UserName,
						Email = applicationUserIdentity.Email,
						Fullname = applicationUserIdentity.Fullname,
						Token = _tokenService.CreateToken(applicationUserIdentity)
					};

					return Ok(applicationUser);
				}
			}

			return BadRequest("Invalid login attempt");
		}
	}
}
