namespace Classes;//We want a class
class Boss
{
     public string Name {get;set;}
     public int Health {get;set;}
     public string Pow {get;set;}
    public Boss()//Constructor
    {
        Name = "\"Shrek's Insecurities\"";
        Health = 800;
        Pow = "Forcing Self-Reflection";
    }

    public int Attack()
    {
        return new Random().Next(1, 4); 
    }

    public void TakeDamage(decimal damage)
    {
        Health -= Convert.ToInt32(damage);
    }
}