using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    /// <summary>
    /// Gerencia o sistema de combate entre monstros.
    /// Utiliza o padrão Strategy para alternar entre diferentes estratégias de combate
    /// como ataque, defesa e habilidades especiais.
    /// </summary>
    public class CombatManager
    {
        /// <summary>
        /// Representa a estratégia atual de combate, como ataque, defesa ou habilidade especial.
        /// </summary>
        private IStrategy strategy;

        /// <summary>
        /// Define a estratégia de combate a ser utilizada.
        /// </summary>
        /// <param name="strategy">A estratégia de combate (ex.: ataque, defesa).</param>
        public void SetStrategy(IStrategy strategy)
        {
            // Define a estratégia atual de combate
            this.strategy = strategy;
        }

        /// <summary>
        /// Executa a ação de combate com base na estratégia definida.
        /// </summary>
        /// <param name="attacker">O monstro que está realizando a ação.</param>
        /// <param name="defender">O monstro adversário que será afetado pela ação.</param>
        public void ExecuteAction(Monster attacker, Monster defender)
        {
            // Executa a estratégia de combate definida
            strategy.Execute(attacker, defender);
        }

        /// <summary>
        /// Realiza uma ação de ataque.
        /// Define a estratégia de ataque e a executa entre os monstros fornecidos.
        /// </summary>
        /// <param name="attacker">O monstro que está atacando.</param>
        /// <param name="defender">O monstro que está sendo atacado.</param>
        public void AttackAction(Monster attacker, Monster defender)
        {
            // Define a estratégia de ataque e a executa
            SetStrategy(new AttackStrategy());
            ExecuteAction(attacker, defender);
        }

        /// <summary>
        /// Realiza uma ação de defesa.
        /// Define a estratégia de defesa e a executa no monstro defensor.
        /// </summary>
        /// <param name="defender">O monstro que está se defendendo.</param>
        public void DefendAction(Monster defender)
        {
            // Define a estratégia de defesa e a executa
            SetStrategy(new DefendStrategy());
            ExecuteAction(defender, defender); 
        }

        /// <summary>
        /// Realiza uma ação de habilidade especial.
        /// Define a estratégia de habilidade especial e a executa entre os monstros fornecidos.
        /// </summary>
        /// <param name="attacker">O monstro que está utilizando a habilidade especial.</param>
        /// <param name="defender">O monstro adversário que será afetado.</param>
        public void SpecialAbilityAction(Monster attacker, Monster defender)
        {
            // Define a estratégia de habilidade especial e a executa
            SetStrategy(new SpecialAbilityStrategy());
            ExecuteAction(attacker, defender);
        }

        /// <summary>
        /// Exibe a saúde atual de dois monstros no console.
        /// </summary>
        /// <param name="monster1">O primeiro monstro.</param>
        /// <param name="monster2">O segundo monstro.</param>
        public void ShowMonstersHealth(Monster monster1, Monster monster2)
        {
            // Exibe a saúde atual de ambos os monstros
            Console.WriteLine($"{monster1.Name} possui {monster1.Health} pontos de vida");
            Console.WriteLine($"{monster2.Name} possui {monster2.Health} pontos de vida");
        }
    }
}
