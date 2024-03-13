using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.Controllers
{
    public class HienThiContactController : Controller
    {
        private ApplicationDbContext _db;
        public HienThiContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var item = _db.GetConfigs.ToList();
            return View(item);
        }
    }
}
