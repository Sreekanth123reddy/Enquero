﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construcorsCSharo
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> orders;

        public Customer()
        {

        }
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }
        public Customer(int id,string name)
            :this(id)
        {
            this.Name = name;
        }

    }
}
