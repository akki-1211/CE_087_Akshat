using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_EFcore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set;}
        public string Details { get; set;}
        public double price { get; set; }
    }
}
