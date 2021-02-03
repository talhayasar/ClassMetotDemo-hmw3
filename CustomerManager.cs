﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo_hmw3
{
    class CustomerManager
    {

        public void List(Customer[]allcustomers)//bunu not al liste şeklinide
        {
            Console.WriteLine("\nCustomers are listning\n****************");
            foreach (Customer item in allcustomers)
            {
                Console.WriteLine("name:{1} sname:{2} age:{3} ıd:{0}\n****************", item.name,item.sname, item.age, item.ıd);
            }
        }
        public void Add()
        {
            Console.WriteLine("\nAdd function is working\n****************");
            Console.WriteLine("\nEnter new customer's name\n****************");
            string newname = Console.ReadLine();
            Console.WriteLine("\nCustomer is adding...\nNew customer {0} is added\n****************", newname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("\nDelete function is on process...\n" +
                "The {0} customer has been deleted\n****************", customer.name);
        }

    }
}