namespace CoreLibrary.Entities
{
    public class Player
    {
        public IList<Monster> Monsters { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
            Monsters = new List<Monster>();
        }

        public void AddMonster(Monster monster)
        {
            Monsters.Add(monster);
        }

        public Monster SelectMonster()
        {
            Console.WriteLine($"{Name}, escolha um monstro para batalhar:");
            for (int i = 0; i < Monsters.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Monsters[i].Name} (Vida: {Monsters[i].Health}, Ataque: {Monsters[i].AttackPower})");
            }

            int choice;
            do
            {
                Console.Write("Digite o número do monstro: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Monsters.Count);

            return Monsters[choice - 1];
        }
    }
}