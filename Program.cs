public interface IDamageable
{
    void TakeDamage(int amount);
    int Health { get; }
}

public class Player : IDamageable
{
    public int Health { get; private set; } = 100;
    public void TakeDamage(int amount)
    {
        Health = Math.Max(Health - amount, 0);
        Console.WriteLine($"Player has taken damage. Health: {Health}");
    }
}

public class Enemy : IDamageable
{
    public int Health { get; private set; } = 100;
    public void TakeDamage(int amount)
    {
        Health = Math.Max(Health - amount, 0);
        Console.WriteLine($"Enemy has taken damage. Health: {Health}");
    }
}

class Program
{

    public static void DealDamage(IDamageable target, int damage)
    {
        target.TakeDamage(damage);
    }

    static void Main(string[] args)
    {
        List<IDamageable> targets = new() 
        {
            new Player(),
            new Enemy(),
            new Enemy(),
            new Enemy()
        };
        foreach(IDamageable target in  targets)
        {
            DealDamage(target, 20);
        }
    }

}