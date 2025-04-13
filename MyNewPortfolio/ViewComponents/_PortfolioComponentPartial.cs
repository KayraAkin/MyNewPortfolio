using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
