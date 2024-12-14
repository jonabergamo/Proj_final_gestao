using CoreLibrary;

/// <summary>
/// Classe principal que inicializa o jogo.
/// Contém o ponto de entrada (Main) do programa.
/// </summary>
class Program
{
    /// <summary>
    /// Método principal (ponto de entrada) do programa.
    /// Inicializa a instância do jogo utilizando o padrão Singleton e inicia a lógica do jogo.
    /// </summary>
    /// <param name="args">Argumentos de linha de comando (não utilizados neste programa).</param>
    static void Main(string[] args)
    {
        // Obtém a instância única do jogo (Singleton)
        Game game = Game.getInstance;

        // Inicia o jogo
        game.StartGame();
    }
}
