using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class SpecialAbilityStrategy : IStrategy
    {
        public void Execute(Monster attacker, Monster defender)
        {
            int specialDamage = attacker.AttackPower + 2; 
            defender.Health -= specialDamage;
            attacker.SpecialAbility();
        }
    }
}
