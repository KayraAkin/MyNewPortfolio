using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents
{
    public class _FooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
