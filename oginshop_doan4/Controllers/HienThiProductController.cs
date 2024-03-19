using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using System.Linq;


namespace oginshop_doan4.Controllers
{
    public class HienThiProductController : Controller
    {
        private ApplicationDbContext _db;
        public HienThiProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int Id)
        {
            var items = _db.GetProducts.ToList();
            if (Id > 0)
            {
                items = items.Where(p => p.CategoryId == Id).ToList();
            }
           
            return View(items);
        }
        public ActionResult _Category(int Id)
        {
            var items = _db.GetProducts.ToList();
            if (Id > 0)
            {
                items = items.Where(p => p.CategoryId == Id).ToList();
            }

            return View("_category",items);
        }
        public IActionResult Detail(int id)
        {
            var item = _db.GetProducts.Find(id);


            return View(item);
        }


    }
}
