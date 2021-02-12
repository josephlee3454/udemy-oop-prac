using System;
using System.Collections.Generic;

namespace c__prac
{   
    public class Customer 
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order >();
        }
        public Customer(int id)//:this() allows us to have acces to the list in this constuctor
            :this()
        {
            this.Id = id; 

        }
        public Customer(int id,string name)//this allows us to have the id fromthe prev method 
            :this(id)
        {   
            this.Name = name;

        }
    }
  

    }
