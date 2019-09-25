using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.ViewModels.Message
{
    public class AllMessagesViewModel
    {
        public List<ReceivedMessageViewModel> ReceivedMessages { get; set; }

        public List<SentMessageViewModel> SentMessages { get; set; }
    }
}
