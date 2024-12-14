using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class CombatManager
    {
        private IStrategy strategy;  // A estratégia atual de combate

        // Método para definir qual estratégia será usada (ataque, defesa, habilidade)
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        // Executa a ação de combate com a estratégia definida
        public void ExecuteAction(Monster attacker, Monster defender)
        {
            strategy.Execute(attacker, defender);
        }

        // Método para realizar uma ação de ataque
        public void AttackAction(Monster attacker, Monster defender)
        {
            SetStrategy(new AttackStrategy());
            ExecuteAction(attacker, defender);
        }

        // Método para realizar uma ação de defesa
        public void DefendAction(Monster defender)
        {
            SetStrategy(new DefendStrategy());
            ExecuteAction(defender, defender); 
        }

        public void SpecialAbilityAction(Monster attacker, Monster defender)
        {
            SetStrategy(new SpecialAbilityStrategy());
            ExecuteAction(attacker, defender);
        }

        public void ShowMonstersHealth(Monster monster1, Monster monster2)
        {
            Console.WriteLine($"{monster1.Name} possui {monster1.Health} pontos de vida");
            Console.WriteLine($"{monster2.Name} possui {monster2.Health} pontos de vida");
        }
    }
}
