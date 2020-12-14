using System;
using Utils;
namespace DungeonsOfDoom.Core.Characters
{
    public class Skeleton : Monster
    {
        public Skeleton() : base("Skeleton", RandomUtils.Dice(6))
        {
        }

        public override AttackResult Attack(Character opponent)
        {
            int damage = 0;
            if (opponent.Health < 30)
            {
                damage = 5;
                opponent.Health -= damage;
            }

            return new AttackResult(this, opponent, damage);
        }
    }
}
