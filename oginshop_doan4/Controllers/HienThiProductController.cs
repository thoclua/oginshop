using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.Controllers
{
    public class HienThiProductController : Controller
    {
        private ApplicationDbContext _db;
        public HienThiProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
