using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    /// <summary>
    /// Representa a estratégia de habilidade especial utilizada durante o combate.
    /// Implementa a interface IStrategy para definir o comportamento de habilidade especial.
    /// </summary>
    public class SpecialAbilityStrategy : IStrategy
    {
        /// <summary>
        /// Executa a ação de uma habilidade especial de um monstro.
        /// Aplica dano especial ao monstro defensor e executa a habilidade especial do atacante.
        /// </summary>
        /// <param name="attacker">O monstro que está utilizando a habilidade especial.</param>
        /// <param name="defender">O monstro adversário que será afetado pela habilidade especial.</param>
        public void Execute(Monster attacker, Monster defender)
        {
            // Calcula o dano especial com base no poder de ataque do atacante
            int specialDamage = attacker.AttackPower + 2;

            // Aplica o dano especial ao defensor
            defender.Health -= specialDamage;

            // Executa a habilidade especial do atacante
            attacker.SpecialAbility();

            // Exibe uma mensagem indicando o uso da habilidade especial (essa lógica pode ser implementada na habilidade especial)
        }
    }
}
