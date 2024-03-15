using Microsoft.AspNetCore.Mvc;

namespace oginshop_doan4.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
