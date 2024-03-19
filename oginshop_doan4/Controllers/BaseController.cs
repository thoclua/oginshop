using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Models;

namespace oginshop_doan4.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IHttpContextAccessor _contextAccessor;
        protected readonly UserManager<CustomUser> _userManager;
        public BaseController(IHttpContextAccessor contextAccessor,
                                UserManager<CustomUser> userManager)
        {
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }
      
        protected async Task<CustomUser> GetCurrentUserAsync()
        {
            var currentUser = _contextAccessor.HttpContext.User;
            var ht = "";
            var userId = "";
            if (currentUser.Identity.IsAuthenticated)
            {
                ht = currentUser.Identity.Name;
                var userTimThay = await _userManager.FindByNameAsync(currentUser.Identity.Name);
                return userTimThay;
            }
            return null;
        }
    }
}
