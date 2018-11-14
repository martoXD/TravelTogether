using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models.enums;

namespace TravelTogether.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [StringLength(400)]
        public string MessageContent { get; set; }

        public bool IsDeleted { get; set; }

        public MessageStatus MessageStatus { get; set; }

        public int SenderId { get; set; }
        public virtual TtUser Sender { get; set; }

        public int ReceiverId { get; set; }
        public virtual TtUser Receiver { get; set; }
    }
}
