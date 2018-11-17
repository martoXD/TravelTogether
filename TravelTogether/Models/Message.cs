using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models.enums;

namespace TravelTogether.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string MessageContent { get; set; }

        public bool IsDeleted { get; set; } = false;

        public MessageStatus MessageStatus { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }
        public virtual TtUser Sender { get; set; }

        [ForeignKey("Receiver")]
        public string ReceiverId { get; set; }
        public virtual TtUser Receiver { get; set; }
    }
}
