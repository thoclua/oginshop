using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiProductByCategoryId : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiProductByCategoryId(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var item = _db.GetProducts.Take(10).ToList();

            return View(item);
        }
    }
}
