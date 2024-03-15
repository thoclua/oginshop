using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiProductTopRated : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiProductTopRated(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var TopRatedProducts = _db.GetProducts.Where(item => item.Rating > 3).Take(3).ToList();

            return View(TopRatedProducts);
        }
    }
}
