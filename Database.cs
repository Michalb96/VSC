using System.Collections.Generic;

namespace epizod1
{
    public interface IDatabase
    {

        void GetUser(string mail);

        void FindOrder (string id);

        void FindUser (string i);

       // void isConnected();

        void SaveChanges();

        int HowManyUsers();

        int HowManyOffers();

        void addNewUser(User user);

         void addNewOrder(Order order);

         void ShowDatabase();
    }
    public class Database : IDatabase
    {
        List <User> UserList = new List<User>();
        List <Order> OrderList = new List<Order>();
        public void addNewUser(User user)
        {
            UserList.Add(user);
        }

        public void addNewOrder(Order order)
        {
            OrderList.Add(order);
        }

        public void FindOrder (string id)
        {
            foreach(Order o in OrderList)
            {

                if(o.Id == id)
                {
                    o.ShowOrder();
                }
               
            }
        }

        public void FindUser (string i)
        {
            bool t=false;
            foreach(User u in UserList)
            {

                if(u.Email == i)
                {
                    u.ShowUser();
                    t=true;
                }
               
            }
            if(t == false)
            System.Console.WriteLine($"There is no User with Email {i} in the List.");
        }

        public void GetUser(string mail)
        {

            //UserList.Find( == mail)
         //  throw new System.NotImplementedException();
        }

        public int HowManyOffers()
        {
            return OrderList.Count;
        }

        public int HowManyUsers()
        {
            return UserList.Count;
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        public void ShowDatabase()
        {
            System.Console.WriteLine("Orders:");
            foreach(Order o in OrderList)
            {

                    o.ShowOrder();
                    System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("Users:");
            foreach(User u in UserList)
            {
                    u.ShowUser();
                    System.Console.WriteLine("\n");
            }
                
        }
        
    
    }



}