using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new CustomerContext())
            {
                List<Customers> custom = context.Customers.ToList();
                foreach(var item in custom)
                {
                    Console.WriteLine(item.Name);
                }
            }
            
        }
    }
}
