using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
