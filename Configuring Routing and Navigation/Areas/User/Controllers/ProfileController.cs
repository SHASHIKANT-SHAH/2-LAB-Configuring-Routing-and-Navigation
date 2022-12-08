using Microsoft.AspNetCore.Mvc;

namespace Configuring_Routing_and_Navigation.Areas.User.Controllers
{
    public class ProfileController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
