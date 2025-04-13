using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
