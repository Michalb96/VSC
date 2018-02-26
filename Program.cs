using System;
using epizod1;
namespace epizod1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to our shop");
            Database database = new Database();

            User user = new User("meho27@gmail.com", "michal5555", "Michal", "Fic", 21, true, 2000, "Normal",database);
            User user1 = new User("mikolajwojewoda@energetyk.com", "energetyka", "Mikolaj", "Wojewoda", 21, true, 10000, "Premium",database);
            User user2 = new User("bugajski.michal96@gmail.com", "dupa123", "Michal", "Bugajski", 21, false, 3000, "Normal",database);

            Order order1 = new Order(database);
            Order order2 = new Order("1234",200,database);
            Order order3 = new Order("32113",300,database);
            Order order4 = new Order("43224",450,database);
            Order order5 = new Order("176676",600,database);

            database.FindOrder("1234");
            order1.setAvailable();
            database.ShowDatabase();
        }
    }
}
