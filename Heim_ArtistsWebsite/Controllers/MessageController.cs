using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Heim_ArtistsWebsite.Models;
using Heim_ArtistsWebsite.Models.db;
using Microsoft.AspNetCore.Mvc;

namespace Heim_ArtistsWebsite.Controllers
{
    public class MessageController : Controller
    {
        IRepositoryMessages rep = new RepositoryMessages();

        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMessage()
        {
            return View(new Message());
        }

        [HttpGet]
        public IActionResult Messages()
        {
            try
            {
                rep.Open();
                List<Message> messages = rep.GetAllMessages();
                rep.Close();
                return View(messages);
            } catch (DbException)
            {
                rep.Close();
                return View("ResultMessage", new ResultMessage("Database-Error", "Couldn't insert message into database!", "Try again!"));
            } finally
            {
                rep.Close();
            }
        }

        [HttpPost]
        public IActionResult NewMessage(Message message)
        {
            if (message == null)
            {
                return RedirectToAction("Contact");
            }

            ValidateMessage(message);

            if (ModelState.IsValid)
            {
                try {
                    rep.Open();
                    if (rep.Insert(message)){
                        return View("ResultMessage", new ResultMessage("Message has been sent!", "Your message is now saved in my database. I will see the message! :)"));
                    }
                } catch(DbException) {
                    return View("ResultMessage", new ResultMessage("Database-Error", "Couldn't insert message into database!", "Try again!"));
                } finally {
                    rep.Close();
                }
                
                return RedirectToAction("index", "message");
            }
            return View(new Message());
        }

        private void ValidateMessage(Message message)
        {
            if (message == null) return;

            if ((message.Sender == null) || (message.Sender.Length <= 5)) {
                ModelState.AddModelError(nameof(Message.Sender), "Please enter a valid name.");
            }

            if ((message.MessageText == null) || (message.MessageText.Length <= 10))
            {
                ModelState.AddModelError(nameof(Message.MessageText), "Please enter a valid message!");
            }
        }
    }
}
