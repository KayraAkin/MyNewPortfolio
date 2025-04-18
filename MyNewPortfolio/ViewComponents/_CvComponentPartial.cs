using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents
{
    public class _CvComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
