namespace Classes;//We want a class
class User
{
     public string Name {get;set;}
     public int Health {get;set;}
     public decimal Wallet {get;set;}
     public decimal Luck {get;set;}
     public int Energy {get;set;}
   
    public User(string name, int health, decimal money, decimal luck, int caffine)//Constructor
    {
        Name = name;
        Health = health;
        Wallet = money;
        Luck = luck;
        Energy = caffine;
    }

    public User()//Used for JSON serialization
    {

    }

    public void TakeDamage(int damage)//This method subtracts health from player's Health
    {
        Health -= damage;
    }
}