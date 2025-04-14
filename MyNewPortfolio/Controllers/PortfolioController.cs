using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;
using MyNewPortfolio.DAL.Entities;

namespace MyNewPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
