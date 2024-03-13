using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.ViewComponents
{
    public class HienThiProductSale : ViewComponent
    {
        private ApplicationDbContext _db;
        public HienThiProductSale(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            List<Product> saleProducts = _db.GetProducts.Where(item => item.Sale == true).Take(3).ToList();


            return View( saleProducts);
        }
    }
}
