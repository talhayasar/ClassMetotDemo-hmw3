using System;

namespace ClassMetotDemo_hmw3
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.name = "jack";
            customer1.sname = "hamilton";
            customer1.ıd = 100;
            customer1.age = 23;
            Customer customer2 = new Customer();
            customer2.name = "ammy";
            customer2.sname = "wattsohn";
            customer2.ıd = 101;
            customer2.age = 44;
            CustomerManager customermanager = new CustomerManager();
            Customer[] allcustomers = new Customer[] { customer1, customer2 };
            
            while (true)
            {   Console.WriteLine("You can select the thing that you want to do\n" +
                "1-List the all customers\n" +
                "2-Add new Customer\n" +
                "3-Delete Customer\n");
                int functionselected = Convert.ToInt32(Console.ReadLine());//bunu not alcan

                if (functionselected==1)
                {
                customermanager.List(allcustomers);//bunu not alcan
                }
                else if (functionselected==2)
                {
                customermanager.Add();
                }
                if (functionselected==3)
                {
                    Console.WriteLine("\nEnter the ıd of the customer\n");
                    int deletenumber = Convert.ToInt32(Console.ReadLine());//bunu not alcan
                    if (deletenumber==100)
                    {
                    customermanager.Delete(customer1);
                    }
                    else if (deletenumber==101)
                    {
                    customermanager.Delete(customer2);
                    }

                }
                
                if (functionselected==-1)
                {
                    Console.WriteLine("\nprogram has been closed\n");
                    break;
                }
                Console.WriteLine("\nTo finish program enter -1\n");
            }
           

        }
    }
}
