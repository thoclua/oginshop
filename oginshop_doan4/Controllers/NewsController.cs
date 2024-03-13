using Microsoft.AspNetCore.Mvc;

namespace oginshop_doan4.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
