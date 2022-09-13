using ConsoleApp1.ADTs;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] company = new Employee[Employee.max];
            Employee employee0 = new Employee();
            employee0.name = "Octavio";
            employee0.salary = 100.10M;

            Employee employee1 = new Employee();
            employee1.name = "Estela";
            employee1.salary = 100.10M;

            employee0.addFriend(employee1);
            employee0.addFriend(employee0);

            company[0] = employee0;

            Product p1 = new Product();
            p1.title = "HELIOS 500";
            p1.description = "Say farewell to your desktop. With an 11th Gen Intel® Core™ i9 Processor1, a GeForce RTX™ 30801, and one of the most cutting-edge displays to grace the base of a laptop chassis – a 4K Mini LED panel1 with 120Hz refresh – you can see why Helios is heralding in the future of gaming.";
            p1.price = 45000;
            p1.quantity = 2;
            p1.code = "001";

            Product p2 = new Product();
            p2.title = "HELIOS 300";
            p2.description = "Say farewell to your desktop. With an 11th Gen Intel® Core™ i9 Processor1, a GeForce RTX™ 30801, and one of the most cutting-edge displays to grace the base of a laptop chassis – a 4K Mini LED panel1 with 120Hz refresh – you can see why Helios is heralding in the future of gaming.";
            p2.price = 25000;
            p2.quantity = 5;
            p2.code = "001";

            Order order = new Order();
            order.add(p1);
            order.add(p2);
            order.discount = 10000;
            order.shipping = 2500;

            //Console.WriteLine("Hello World!");
        }
    }
}
