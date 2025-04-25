namespace Classes;//We want a class
class NPC 
{
     public string Name {get;set;}
     public int Health {get;set;}
     public string Pow {get;set;}
    public NPC(string name, int health, string pow)//Constructor
    {
        Name = name;
        Health = health;
        Pow = pow;
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