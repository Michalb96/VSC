using System;

namespace epizod1 {
    public class User {

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public decimal Age { get; private set; }
        public bool isActive { get; private set; }

        public double Cash { get; private set; }
        public string Comment { get; private set; }

        public string UserType { get; private set;}


        /*********************** METODS ************************** */
        public User (string mail, string pass , string usertype,Database database ) {
            Email = mail;
            Password = pass;
            UserType = usertype;
            database.addNewUser(this);
        }
        public User (string mail, string password, string name, string surname, decimal age, bool isactive, double cash,string usertype, Database database) {
            Email = mail;
            Password = password;
            Name = name;
            Surname = surname;
            Age = age;
            isActive = isactive;
            Cash = cash;
            UserType = usertype;
            database.addNewUser(this);

        }
        public void setMail (string m) {
            if (m == null) {
                throw new System.Exception ("Mail is incorret.");
            }

            Email = m;
        }
        public void setUserType (string u) {
            if (u != "Premium" || u != "Normal") {
                throw new System.Exception ("User can be  Normal or Premium");
            }

            UserType = u;
        }
        
        public string GetUserType()
        {
            return UserType;
        }

        public void setPassword (string p) {
            if (p == null) {
                throw new System.Exception ("Password is incorret.");
            }

            Password = p;
        }
        public void setName (string n) {
            if (n == null) {
                throw new System.Exception ("Name is incorret.");
            }

            Name = n;
        }
        public void setSurname (string s) {
            if (s == null) {
                throw new System.Exception ("Surname is incorret.");
            }

            Surname = s;
        }
        public void setAge (decimal a) {
            if (a <= 0) {
                throw new System.Exception ("Age is incorret.");
            }

            Age = a;
        }

        public void checkActive () {
            if (isActive == false) {
                System.Console.WriteLine ("User is not active.");
            }
            else System.Console.WriteLine ("User is active.");
        }
        /*public void setActive () {
            if (isActive == true){
                System.Console.WriteLine ("User is already active.");
                return;}

            isActive = true;

        }*/

        public void setCash (double c) {
            if (c < 0)
                throw new System.Exception ("Amount of cash is invalid.");

            Cash = c;
        }
        public void isAffordable (Order order) {
            if (order.TotalPrice > Cash)
                System.Console.WriteLine ("You dont have enough money.");

            System.Console.WriteLine ("You can afford that.");
        }

        public void ActiveUser () {

            this.isActive = true;
        }

        public void PurchaseProduct (Order order) {
            if (order.TotalPrice > Cash) {
                System.Console.WriteLine ("You dont have enough money.");
                return;
            }
            Cash = Cash - order.TotalPrice;
        }
        public void ShowUser() {
            System.Console.WriteLine( $"User email: {this.Email}\n");
            System.Console.WriteLine( $"User password: {this.Password}\n");
            System.Console.WriteLine( $"User name: {this.Name}\n");
            System.Console.WriteLine( $"User surname: {this.Surname}\n");
            System.Console.WriteLine( $"User age: {this.Age}\n");
            System.Console.WriteLine( $"Is active: {this.isActive}\n");
            System.Console.WriteLine( $"USer bank account: {this.Cash}\n");
            System.Console.WriteLine( $"User comment: {this.Comment}\n");
            System.Console.WriteLine( $"User Type: {this.UserType}\n");

    }


    }

   

}