using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ADTs
{
    public class Order
    {
        private List<Product> products { get; set; }
        public float discount { get; set; }
        public float shipping { get; set; }
        
        public float total => getTotal();

        public Order()
        {
            this.products = new List<Product>();
        }

        private float getTotal()
        {
            float total = 0;
            foreach(Product product in this.products)
            {
                total = total + product.total;
            }

            total = total + shipping - discount;

            return total;
        }

        public void add(Product newProduct)
        {
            bool found = false;
            foreach(Product p in products)
            {
                if(p.code == newProduct.code)
                {
                    p.quantity = p.quantity + 1;
                    found = true;
                }
            }
            if(!found)
            {
                products.Add(newProduct);
            }
        }
        //public void addB(Product newProduct)
        //{
        //    bool found = false;
        //    foreach (Product p in products)
        //    {
        //        if (p.code == newProduct.code)
        //        {
        //            p.quantity = p.quantity + 1;
        //            found = true;
        //            break;
        //        }
        //    }
        //    if (!found)
        //    {
        //        products.Add(newProduct);
        //    }
        //}
    }
}
