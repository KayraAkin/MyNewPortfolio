using Microsoft.AspNetCore.Mvc;
using MyNewPortfolio.DAL.Context;
using MyNewPortfolio.DAL.Entities;

namespace MyNewPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = _context.Messages.Find(id);
            value.IsRead = true;
            _context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = _context.Messages.Find(id);
            value.IsRead = false;
            _context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var value = _context.Messages.Find(id);
            return View(value);
        }


        
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            
            if (ModelState.IsValid) // Verilerin doğru olup olmadığını kontrol et
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;
                _context.Messages.Add(message);
                _context.SaveChanges();
                return Ok(); // Başarıyla veriyi kaydettik
                
            }
            return BadRequest();
        }
    }
}
