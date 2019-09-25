using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;
using TravelTogether.Models.enums;

namespace TravelTogether.ViewModels.Message
{
    public class ReceivedMessageViewModel
    {
        public int Id { get; set; }

        public string MessageContent { get; set; }

        public bool IsDeleted { get; set; } = false;

        public MessageStatus MessageStatus { get; set; }

        public string SenderId { get; set; }
        public virtual TtUser Sender { get; set; }

        public string ReceiverId { get; set; }
        public virtual TtUser Receiver { get; set; }
    }
}
