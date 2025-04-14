using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;
using Newtonsoft.Json.Linq;

namespace MyNewPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            ViewBag.aboutTitle = _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = _context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = _context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}