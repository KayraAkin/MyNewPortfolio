using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;

namespace MyNewPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = _context.Skills.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Messages.Where(x=> x.IsRead == false).Count();
            ViewBag.v4 = _context.Messages.Where(x=> x.IsRead == true).Count();
            ViewBag.v5 = _context.Portfolios.Count();
            ViewBag.V6 = _context.Portfolios.OrderBy(x=> x.PortfolioId).FirstOrDefault()?.Title;
            ViewBag.v7 = _context.Experiences.Count();
            ViewBag.v8 = _context.Experiences.OrderBy(x=> x.ExperienceId).Take(1).Select(v => v.Head + "-"+ v.Title).FirstOrDefault();
            ViewBag.v9 = _context.Testimonials.Count();
            ViewBag.v10 = _context.Testimonials.OrderBy(x=> x.TestimonialId).FirstOrDefault()?.NameSurname;
            ViewBag.v11 = _context.Testimonials.OrderByDescending(x=> x.TestimonialId).FirstOrDefault()?.NameSurname;

            return View();
        }
    }
}
