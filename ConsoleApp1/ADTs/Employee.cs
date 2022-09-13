using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ADTs
{
    class Employee
    {
        public static readonly int max = 5;

        public String name { get; set; }
        public decimal salary { get; set; }
        public decimal salaryMonth => salary * 30;
        protected List<Employee> friends { get; set; }

        public Employee()
        {
            this.friends = new List<Employee>();
        }

        public void addFriend(Employee friend)
        {
            if(this.name == friend.name)
            {
                Console.WriteLine("Employee can´t be friend of his/her self");
            }
            else
            {
                this.friends.Add(friend);
            }
        }
    }
}
