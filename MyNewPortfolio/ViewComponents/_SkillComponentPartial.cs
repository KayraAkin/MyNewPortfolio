using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
