using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace oginshop_doan4.Controllers
{
	public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> _logger;
		private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(IHttpContextAccessor contextAccessor, UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager) : base(contextAccessor, userManager)
        {
            _roleManager = roleManager;
        }
		public async Task<IActionResult> SeedingRole()
		{
			var dbSeedRole = new DbSeedRole(_roleManager);
			await dbSeedRole.RoleData();
			return Ok("Seed role thanh cong!");
		}
        public async Task <IActionResult> Index()
		{
			var currentUser = await GetCurrentUserAsync();
			if (currentUser != null) 
			{
				ViewBag.HT = currentUser.UserName;
            }		
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}