using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiProductSaleByCategory : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiProductSaleByCategory(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var item = _db.GetProducts.Where(item => item.Sale == true).Take(6).ToList();
            return View(item);
        }

    }
}
