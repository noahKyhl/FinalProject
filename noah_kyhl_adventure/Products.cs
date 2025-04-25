namespace Classes;//We want a class

class Products
{
     public string Name {get;set;}
     public decimal Price {get;set;}
     public decimal Quant {get;set;}
     public int Health {get;set;} 
     public int Energy {get;set;}
    public Products(string name, decimal price, decimal quant, int health, int energy)//Constructor
    {
        Name = name;
        Price = price;
        Quant = quant;
        Health = health;
        Energy = energy;
    }
}
