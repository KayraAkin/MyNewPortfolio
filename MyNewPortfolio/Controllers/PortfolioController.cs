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
        public IActionResult DeletePortfolio(int id)
        {
            var values = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = _context.Portfolios.Find(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
