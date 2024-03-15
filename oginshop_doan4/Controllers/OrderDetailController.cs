using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.DataTransferObject;
using oginshop_doan4.Models;
using oginshop_doan4.Repository;

namespace oginshop_doan4.Controllers
{
    public class OrderDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
