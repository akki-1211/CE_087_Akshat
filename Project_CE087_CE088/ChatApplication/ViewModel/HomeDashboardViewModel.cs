using ChatApplication.Areas.Identity.Data;
using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.ViewModel
{
    public class HomeDashboardViewModel
    {
        public IList<ChatApplicationUser> Users { get; set; }
        public IList<Message> MessagesBetween { get; set; }
        public ChatApplicationUser ReceiverUser { get; set; }
        public IDictionary<string, Message> LastMessageBetweenTwoUser { get; set; }
        //public Message Message { get; set; }
    }
}
