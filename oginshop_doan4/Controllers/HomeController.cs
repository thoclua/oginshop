using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.Models;
using System.Diagnostics;

namespace oginshop_doan4.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
       // private ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		//public HomeController (ApplicationDbContext db)
		//{
  //          _db = db;
  //      }

		public IActionResult Index()
		{
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