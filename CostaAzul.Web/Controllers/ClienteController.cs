using Microsoft.AspNetCore.Mvc;

namespace CostaAzul.Web.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
