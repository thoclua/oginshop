using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiCategory : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiCategory(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var item = _db.GetCategories.ToList();
            return View(item);
        }
    }
}
