using CoreLibrary.Entities;

/// <summary>
/// Fábrica responsável por criar instâncias de diferentes tipos de monstros.
/// Simplifica a criação de monstros centralizando a lógica de inicialização.
/// </summary>
public class MonsterFactory
{
    /// <summary>
    /// Cria um monstro do tipo especificado com os atributos fornecidos.
    /// </summary>
    /// <param name="type">O tipo do monstro (ex.: "Goblin", "Robot").</param>
    /// <param name="name">O nome do monstro.</param>
    /// <param name="attack">O valor do ataque do monstro.</param>
    /// <param name="defense">O valor da defesa do monstro.</param>
    /// <param name="health">O valor da saúde do monstro.</param>
    /// <returns>Uma instância de um monstro específico baseado no tipo.</returns>
    /// <exception cref="ArgumentException">Lança uma exceção se o tipo do monstro for inválido.</exception>
    public Monster CreateMonster(string type, string name, int attack, int defense, int health)
    {
        // Retorna uma instância do monstro com base no tipo especificado
        return type switch
        {
            "Goblin" => new Goblin(name, attack, defense, health),
            "Robot" => new Robot(name, attack, defense, health),
            "Zombie" => new Zombie(name, attack, defense, health),
            "Dragon" => new Dragon(name, attack, defense, health),
            _ => throw new ArgumentException("Tipo de monstro inválido")
        };
    }
}
