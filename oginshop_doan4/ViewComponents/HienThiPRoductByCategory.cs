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

            var items = _db.GetCategories.ToList();
           
           
            return View(items);
        }
    }
}
