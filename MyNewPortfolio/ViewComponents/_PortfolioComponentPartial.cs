using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;

namespace MyNewPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
    }
}
