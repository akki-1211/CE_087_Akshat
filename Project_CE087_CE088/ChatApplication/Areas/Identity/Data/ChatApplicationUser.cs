using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApplication.Models;
using Microsoft.AspNetCore.Identity;

namespace ChatApplication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ChatApplicationUser class
    public class ChatApplicationUser : IdentityUser
    {
        // For Messages
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
    }
}
