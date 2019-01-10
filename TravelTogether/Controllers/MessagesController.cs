using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.Models.enums;

namespace TravelTogether.Controllers
{
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public MessagesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Send(string senderId, string receiverId, string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                var sender = this.dbContext.Users.FirstOrDefault(u => u.Id == senderId);
                var receiver = this.dbContext.Users.FirstOrDefault(u => u.Id == receiverId);

                if (ModelState.IsValid)
                {
                    var message = new Message
                    {
                        IsDeleted = false,
                        MessageContent = content,
                        MessageStatus = MessageStatus.Sent,
                        Sender = sender,
                        Receiver = receiver
                    };

                    sender.SentMessages.Add(message);
                    receiver.ReceivedMessages.Add(message);
                    this.dbContext.Messages.Add(message);
                    this.dbContext.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}