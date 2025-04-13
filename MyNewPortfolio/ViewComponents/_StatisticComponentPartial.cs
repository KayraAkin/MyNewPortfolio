using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
