using CoreLibrary.Entities;
using CoreLibrary;

public class Game
{
    private static Game? instance;
    private static readonly object lockObject = new();

    private Game() { }

    public static Game getInstance
    {
        get
        {
            lock (lockObject)
            {
                return instance ??= new Game();
            }
        }
    }

    public void StartGame()
    {
        Player player1 = new("Player 1");
        Player player2 = new("Player 2");

        MonsterFactory factory = new();

        // Criação de monstros usando a fábrica
        player1.AddMonster(factory.CreateMonster("Robot", "Robo", 40, 25, 200));
        player1.AddMonster(factory.CreateMonster("Dragon", "Dragão", 50, 35, 180));
        player2.AddMonster(factory.CreateMonster("Zombie", "Zumbi", 30, 15, 250));
        player2.AddMonster(factory.CreateMonster("Goblin", "Goblin", 25, 20, 220));

        Console.WriteLine("Batalha de Monstros começou!");

        // Seleção de monstros
        Monster player1Monster = player1.SelectMonster();
        Monster player2Monster = player2.SelectMonster();

        Console.WriteLine($"Player 1 escolheu {player1Monster.Name}");
        Console.WriteLine($"Player 2 escolheu {player2Monster.Name}");

        // Configuração do Observer para monitorar a saúde
        HealthObserver observer = new();
        player1Monster.AddObserver(observer);
        player2Monster.AddObserver(observer);

        // Gerenciamento de turnos
        TurnManager turnManager = new();

        bool gameOver = false;
        int round = 1;

        while (!gameOver)
        {
            Console.WriteLine($"\n--- Turno {round} ---");

            Console.WriteLine("\nPlayer 1:");
            turnManager.StartTurn(player1Monster, player2Monster);

            if (player2Monster.Health <= 0)
            {
                Console.WriteLine("Player 1 venceu!");
                gameOver = true;
                break;
            }

            Console.WriteLine("\nPlayer 2:");
            turnManager.StartTurn(player2Monster, player1Monster);

            if (player1Monster.Health <= 0)
            {
                Console.WriteLine("Player 2 venceu!");
                gameOver = true;
                break;
            }

            round++;
        }
    }
}
