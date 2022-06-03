using Microsoft.AspNetCore.Mvc;

namespace TataSteel.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
