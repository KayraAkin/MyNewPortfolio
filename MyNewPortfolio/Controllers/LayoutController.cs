using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
