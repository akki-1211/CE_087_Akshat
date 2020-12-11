using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_EFcore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public Customer customer { get; set;}

        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
