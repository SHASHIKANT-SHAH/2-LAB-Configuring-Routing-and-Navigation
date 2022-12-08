using Configuring_Routing_and_Navigation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Configuring_Routing_and_Navigation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(model.Username == "admin@gmail.com" && model.Password == "12345678")
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                }
                else if (model.Username == "user@gmail.com" && model.Password == "12345678")
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "User" });
                }
            }
            return View();
        }
        public ViewResult Logout()
        {
            return View();
        }
    }
}
