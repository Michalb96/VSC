namespace epizod1
{
    public class Order
    {
        public string Id {get; private set;}
        public double Price {get; private set;}
        public double Tax{get; private set;}
        public double TotalPrice { get { return (1+Tax)*Price;} }
        public bool isAvailable {get; private set;}

        public int HowLong {get; private set;}

        /*********************** METODS ************************** */
      
      public Order(string id, double price, Database database)
      {
          Id = id;
          Price = price;
          database.addNewOrder(this);
      }
      public Order(Database database)
      {
         database.addNewOrder(this);
      }
      public void UserType(User user)
      { 
            if( user.GetUserType() == "Normal")
            Tax = 0.23*Price;
            
            else Tax = 0.15 * Price;
      }
      public void setId(string i)  
      {
          if(i == null)
          throw new System.Exception("Id number is invalid.");
        Id=i;
      }
      public void setMoney(double m)  
      {
          if(m <=0)
          throw new System.Exception("Money amount is invalid.");
        Price=m;
      }
    public void ifAvailable()
    {
        if(!isAvailable)
        throw new System.Exception("Order is not available.");
        isAvailable = true;
    }
    public void chceckAge(User user)
    {
      if(user.Age<13)
      throw new System.Exception("Your age is not valid.");

            System.Console.WriteLine("Your age is sufficient to buy.");
    }
    public void setAvailable()
    {
      isAvailable=true;
    }

    public void ShowOrder()
    {
      System.Console.WriteLine( $"Id order: {this.Id}\n");
      System.Console.WriteLine( $"Price of order: {this.Price}\n");
      System.Console.WriteLine( $"Checking available: {this.isAvailable}\n");

    }

   }

}