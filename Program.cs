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
        Health -= Math.Max(Health = amount, 0);
        Console.WriteLine($"Player has taken damage. Health: {Health}");
    }

    public void DealDamage(IDamageable target, int damage)
    {

    }
}

public class Enemy : IDamageable
{
    public int Health { get; private set; } = 100;
    public void TakeDamage(int amount)
    {
        Health -= Math.Max(Health = amount, 0);
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
        Player player = new();
        Enemy enemy = new();
        DealDamage(player, 20);
        DealDamage(enemy, 30);
    }

}