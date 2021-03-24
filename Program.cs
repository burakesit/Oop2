using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Name = "Burak";
            customer1.SurName = "Eşit";
            customer1.Id = 1;
            customer1.IdNumber = "22222222";
            customer1.CustomerNumber = "12345";

            //Kodlama.io

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "5468451";
            customer2.CompanyName = "Kodlama.io";
            customer2.TasksNumber = "87978";

            //Gerçek Müşteri-Tüzel Müşteri(Şirket adı kısmında bu önem arz eden bir durumdur.)
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);





        }
    }
}
