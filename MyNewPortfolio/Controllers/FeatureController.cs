using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;
using MyNewPortfolio.DAL.Entities;

namespace MyNewPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult FeatureList()
        {
            var values = _context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = _context.Features.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction(nameof(FeatureList));
        }
    }
}
