using CoreLibrary.Entities;

namespace CoreLibrary
{
    /// <summary>
    /// Gerencia os turnos do jogo, permitindo que cada jogador realize ações em ordem alternada.
    /// </summary>
    public class TurnManager
    {
        /// <summary>
        /// Número do turno atual.
        /// </summary>
        private int currentTurn = 1;

        /// <summary>
        /// Inicia um turno, permitindo que o jogador atual escolha uma ação.
        /// </summary>
        /// <param name="playerMonster">Monstro do jogador atual.</param>
        /// <param name="opponentMonster">Monstro do oponente.</param>
        public void StartTurn(Monster playerMonster, Monster opponentMonster)
        {
            // Limpa o console para exibir informações atualizadas
            Console.Clear();

            // Mostra o status atual dos monstros
            ShowMonsterStatus(playerMonster, opponentMonster);

            // Indica qual jogador está no turno
            Console.WriteLine($"\n===== Turno {currentTurn} =====");
            Monster currentPlayerMonster = currentTurn % 2 != 0 ? playerMonster : opponentMonster;
            Console.WriteLine($"É a vez de {currentPlayerMonster.Name} tomar uma ação!");

            // Menu de ações disponíveis
            Console.WriteLine("\nEscolha uma ação:");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Defender");
            Console.WriteLine("3. Usar Habilidade Especial");

            string choice = Console.ReadLine();

            // Executa a ação escolhida
            switch (choice)
            {
                case "1":
                    Attack(currentPlayerMonster, currentPlayerMonster == playerMonster ? opponentMonster : playerMonster);
                    break;
                case "2":
                    Defend(currentPlayerMonster);
                    break;
                case "3":
                    currentPlayerMonster.SpecialAbility();
                    Console.WriteLine($"{currentPlayerMonster.Name} usou {currentPlayerMonster.AbilityName}!");
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    StartTurn(playerMonster, opponentMonster);
                    return; // Retorna para evitar incrementar o turno
            }

            // Incrementa o turno
            currentTurn++;

            // Aguarda para continuar o jogo
            PressEnterToContinue();
            StartTurn(playerMonster, opponentMonster);
        }

        /// <summary>
        /// Realiza um ataque entre o atacante e o defensor.
        /// </summary>
        /// <param name="attacker">Monstro atacante.</param>
        /// <param name="defender">Monstro defensor.</param>
        private void Attack(Monster attacker, Monster defender)
        {
            Console.WriteLine($"\n{attacker.Name} ataca {defender.Name}!");
            int finalDamage = defender.TakeDamage(attacker.AttackPower);
            Console.WriteLine($"{attacker.Name} causou {finalDamage} de dano!");
            Console.WriteLine($"{defender.Name} agora tem {defender.Health} de vida.");
        }

        /// <summary>
        /// Realiza a ação de defesa do monstro.
        /// </summary>
        /// <param name="monster">Monstro que está se defendendo.</param>
        private void Defend(Monster monster)
        {
            Console.WriteLine($"\n{monster.Name} está se defendendo, preparando para reduzir o dano recebido!");
        }

        /// <summary>
        /// Exibe o status atual dos dois monstros.
        /// </summary>
        /// <param name="playerMonster">Monstro do jogador.</param>
        /// <param name="opponentMonster">Monstro do oponente.</param>
        private void ShowMonsterStatus(Monster playerMonster, Monster opponentMonster)
        {
            Console.WriteLine("======================================");
            Console.WriteLine($"Player 1: {playerMonster.Name}");
            Console.WriteLine($"Vida: {playerMonster.Health}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Player 2: {opponentMonster.Name}");
            Console.WriteLine($"Vida: {opponentMonster.Health}");
            Console.WriteLine("======================================");
        }

        /// <summary>
        /// Aguarda o jogador pressionar Enter para continuar o jogo.
        /// </summary>
        private void PressEnterToContinue()
        {
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
