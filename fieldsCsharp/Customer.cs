using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsCsharp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> orders = new List<Order>();
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            //  orders = new List<Order>();     
        }


    }
}
