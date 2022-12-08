using Microsoft.AspNetCore.Mvc;

namespace Configuring_Routing_and_Navigation.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
