using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;
using MyNewPortfolio.DAL.Entities;

namespace MyNewPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList(); 
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return View(value);
        }
        public IActionResult UpdateContact(Contact contact) 
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");

        }
    }
}
