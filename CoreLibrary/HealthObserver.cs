using CoreLibrary.Entities;

/// <summary>
/// Observador que monitora alterações na saúde de um monstro.
/// Implementa a interface IObserver para receber notificações
/// sempre que um monstro sofre mudanças em sua saúde.
/// </summary>
public class HealthObserver : IObserver
{
    /// <summary>
    /// Método chamado sempre que a saúde de um monstro é alterada.
    /// </summary>
    /// <param name="monster">O monstro que teve sua saúde alterada.</param>
    public void Update(Monster monster)
    {
        // Exibe uma mensagem informando a nova saúde do monstro
        Console.WriteLine($"[Observer] {monster.Name} agora tem {monster.Health} pontos de vida.");
    }
}