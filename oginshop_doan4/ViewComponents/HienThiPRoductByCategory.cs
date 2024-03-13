using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiPRoductByCategory : ViewComponent
    {
        private ApplicationDbContext _db;

        public HienThiPRoductByCategory(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke(int Id)
        {

            var items = _db.GetProducts.ToList();
            if (Id > 0)
            {
                items = items.Where(p => p.CategoryId == Id).ToList();
            }
           
            return View(items);
        }
    }
}
