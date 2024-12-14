using CoreLibrary.Entities;

namespace CoreLibrary.Interfaces
{
    /// <summary>
    /// Define a interface para estratégias de combate no jogo.
    /// Cada estratégia de combate deve implementar este método para definir
    /// o comportamento específico (ex.: ataque, defesa, habilidade especial).
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Executa a ação da estratégia, afetando o monstro atacante e o defensor.
        /// </summary>
        /// <param name="attacker">O monstro que está realizando a ação.</param>
        /// <param name="defender">O monstro adversário que será afetado pela ação.</param>
        void Execute(Monster attacker, Monster defender);
    }
}
