using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    /// <summary>
    /// Representa a estratégia de defesa utilizada durante o combate.
    /// Implementa a interface IStrategy para definir o comportamento de defesa.
    /// </summary>
    public class DefendStrategy : IStrategy
    {
        /// <summary>
        /// Executa a ação de defesa de um monstro.
        /// Aumenta temporariamente a defesa do monstro defensor.
        /// </summary>
        /// <param name="defender">O monstro que está se defendendo.</param>
        /// <param name="attacker">O monstro adversário (não utilizado nesta estratégia).</param>
        public void Execute(Monster defender, Monster attacker)
        {
            // Armazena o valor inicial da defesa
            int initialDefense = defender.Defense;

            // Aumenta a defesa do defensor
            defender.Defense += 10;

            // Exibe uma mensagem indicando a ação de defesa
            Console.WriteLine($"{defender.Name} se defende e aumenta sua defesa!");
        }
    }
}
