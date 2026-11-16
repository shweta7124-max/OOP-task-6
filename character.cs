
namespace PolymorphismTutorial.Classes;

public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    protected int AttackDamage { get; set; }

    public Character(string name, int health, int attackDamage)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name} - Health: {Health}");
    }

    public abstract void PerformAttack(Character target);
}
