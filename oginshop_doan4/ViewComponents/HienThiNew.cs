using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiNew : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiNew(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var item = _db.GetNews.Take(3).ToList();
            return View(item);
        }
    }
}
