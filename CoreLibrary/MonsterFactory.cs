using CoreLibrary.Entities;

public class MonsterFactory
{
    public Monster CreateMonster(string type, string name, int attack, int defense, int health)
    {
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
