
using PolymorphismTutorial.Classes;

Character player = new Warrior("Aragorn");
Character enemy = new Mage("Merlin");

Console.WriteLine("=== BATTLE START ===");

player.ShowStatus();
enemy.ShowStatus();

Console.WriteLine("\n--- Player attacks ---");
player.PerformAttack(enemy);

Console.WriteLine("\n--- Enemy attacks ---");
enemy.PerformAttack(player);

Console.WriteLine("\n--- Type checking with is ---");

if (player is Warrior)
{
    Console.WriteLine($"{player.Name} is a Warrior!");
}

if (enemy is Mage)
{
    Console.WriteLine($"{enemy.Name} is a Mage!");
}

Console.WriteLine("\n--- Type conversion with as ---");

Warrior? warrior = player as Warrior;

if (warrior != null)
{
    Console.WriteLine($"Successfully converted {warrior.Name} to Warrior.");
}

Mage? mage = player as Mage;

if (mage == null)
{
    Console.WriteLine("Player is not a Mage.");
}

Console.WriteLine("\n=== BATTLE END ===");
