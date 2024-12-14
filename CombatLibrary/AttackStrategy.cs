using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    /// <summary>
    /// Representa a estratégia de ataque utilizada durante o combate.
    /// Implementa a interface IStrategy para definir o comportamento de ataque.
    /// </summary>
    public class AttackStrategy : IStrategy
    {
        /// <summary>
        /// Executa a ação de ataque de um monstro contra outro.
        /// Calcula o dano baseado na diferença entre o poder de ataque do atacante 
        /// e a defesa do defensor. Se o dano for negativo, é tratado como zero.
        /// </summary>
        /// <param name="attacker">O monstro que está atacando.</param>
        /// <param name="defender">O monstro que está sendo atacado.</param>
        public void Execute(Monster attacker, Monster defender)
        {
            // Calcula o dano com base na diferença entre ataque e defesa
            int damage = attacker.AttackPower - defender.Defense;
            
            // Se o dano for negativo, é ajustado para zero
            damage = damage > 0 ? damage : 0;

            // Subtrai o dano da saúde do defensor
            defender.Health -= damage;

            // Exibe a mensagem de ataque e o dano causado
            Console.WriteLine($"{attacker.Name} atacou {defender.Name} e causou {damage} pontos de dano em {defender.Name}.");
        }
    }
}
