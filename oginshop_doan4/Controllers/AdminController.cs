using Microsoft.AspNetCore.Mvc;

namespace oginshop_doan4.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
