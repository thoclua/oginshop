<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
=======
﻿using Microsoft.AspNetCore.Mvc;
>>>>>>> 42ebf3b561f70bfc346f3d9ef33ed0291e66411c
using oginshop_doan4.Data;
using oginshop_doan4.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace oginshop_doan4.Controllers
{
	public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> _logger;
<<<<<<< HEAD
		private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(IHttpContextAccessor contextAccessor, UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager) : base(contextAccessor, userManager)
        {
            _roleManager = roleManager;
        }
		public async Task<IActionResult> SeedingRole()
=======
       // private ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger)
>>>>>>> 42ebf3b561f70bfc346f3d9ef33ed0291e66411c
		{
			var dbSeedRole = new DbSeedRole(_roleManager);
			await dbSeedRole.RoleData();
			return Ok("Seed role thanh cong!");
		}
<<<<<<< HEAD
        public async Task <IActionResult> Index()
=======

		//public HomeController (ApplicationDbContext db)
		//{
  //          _db = db;
  //      }

		public IActionResult Index()
>>>>>>> 42ebf3b561f70bfc346f3d9ef33ed0291e66411c
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