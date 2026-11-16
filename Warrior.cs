
using System;

namespace PolymorphismTutorial.Classes;

public class Warrior : Character
{
    public Warrior(string name)
        : base(name, 120, 20)
    {
    }

    public sealed override void PerformAttack(Character target)
    {
        Console.WriteLine(
            $"{Name} attacks {target.Name} with a sword for {AttackDamage} damage!"
        );

        target.Health -= AttackDamage;
    }
}
