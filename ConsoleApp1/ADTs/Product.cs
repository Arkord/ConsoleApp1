using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ADTs
{
    public class Product
    {
        public string title { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public string code { get; set; }
        public float total => price * quantity;


    }
}
