
using System;

namespace PolymorphismTutorial.Classes;

public sealed class Mage : Character
{
    public Mage(string name)
        : base(name, 80, 30)
    {
    }

    public override void PerformAttack(Character target)
    {
        Console.WriteLine(
            $"{Name} casts a magic spell on {target.Name} for {AttackDamage} damage!"
        );

        target.Health -= AttackDamage;
    }
}
