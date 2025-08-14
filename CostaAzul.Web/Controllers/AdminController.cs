using Microsoft.AspNetCore.Mvc;

namespace CostaAzul.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
