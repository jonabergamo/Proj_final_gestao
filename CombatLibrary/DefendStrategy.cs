using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class DefendStrategy : IStrategy
    {
        public void Execute(Monster defender, Monster attacker)
        {
            int initialDefense = defender.Defense;
            defender.Defense += 10;
            Console.WriteLine($"{defender.Name} se defende e aumenta sua defesa!");
        }
    }
}
