using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;
using MyNewPortfolio.DAL.Entities;

namespace MyNewPortfolio.ViewComponents
{
    public class _MessageComponentPartial : ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }
    }
}
