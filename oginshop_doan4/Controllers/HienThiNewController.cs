using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.Controllers
{
    public class HienThiNewController : Controller
    {
        private ApplicationDbContext _db;
        public HienThiNewController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var item = _db.GetNews.ToList();
            return View(item);
        }
        public IActionResult Detail(int id)
        {
            var item = _db.GetNews.Find(id);
           
            return View(item);
        }
    }
}
