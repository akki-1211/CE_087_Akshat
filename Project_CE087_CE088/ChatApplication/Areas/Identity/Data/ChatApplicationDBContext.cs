using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApplication.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatApplication.Models
{
    public class ChatApplicationDBContext : IdentityDbContext<ChatApplicationUser>
    {
        public ChatApplicationDBContext()
        {
        }

        public ChatApplicationDBContext(DbContextOptions<ChatApplicationDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // for Message table
            builder.Entity<Message>()
                .HasOne(mes => mes.SenderUser)
                .WithMany(u => u.MessagesSent)
                .HasForeignKey(mes => mes.SenderUserID);

            builder.Entity<Message>()
                .HasOne(mes => mes.ReceiverUser)
                .WithMany(u => u.MessagesReceived)
                .HasForeignKey(mes => mes.ReceiverUserID);
        }
        public DbSet<Message> Messages { get; set; }
    }
}
