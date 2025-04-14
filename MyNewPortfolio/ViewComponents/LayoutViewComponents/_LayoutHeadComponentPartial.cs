using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
