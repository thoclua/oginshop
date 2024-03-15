using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiSlider : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiSlider(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var selectedBanner = _db.GetBanners.Where(item => item.id == 1 || item.id == 2).ToList();
            return View(selectedBanner);
        }
    }
}
