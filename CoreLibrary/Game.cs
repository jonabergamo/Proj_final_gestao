using CoreLibrary.Entities;
using CoreLibrary;

public class Game
{
    /// <summary>
    /// Instância única da classe Game (Singleton).
    /// </summary>
    private static Game? instance;

    /// <summary>
    /// Objeto para controle de concorrência na criação da instância.
    /// </summary>
    private static readonly object lockObject = new();

    /// <summary>
    /// Construtor privado para impedir a criação de múltiplas instâncias.
    /// </summary>
    private Game() { }

    /// <summary>
    /// Propriedade que retorna a instância única da classe Game.
    /// Implementa o padrão Singleton.
    /// </summary>
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

    /// <summary>
    /// Inicia o jogo, configurando os jogadores, monstros e turnos.
    /// </summary>
    public void StartGame()
    {
        // Criação dos jogadores
        Player player1 = new("Player 1");
        Player player2 = new("Player 2");

        // Criação de monstros usando a fábrica
        MonsterFactory factory = new();
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

        // Loop principal do jogo
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
