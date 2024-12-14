using CoreLibrary.Entities;

namespace CoreLibrary
{
    public class TurnManager
    {
        private int currentTurn = 1;

        public void StartTurn(Monster playerMonster, Monster opponentMonster)
        {
            // Limpa o console a cada turno para garantir uma tela limpa
            Console.Clear();

            // Exibe as informações atuais de ambos os monstros
            ShowMonsterStatus(playerMonster, opponentMonster);

            // Exibe o turno atual e o jogador que está fazendo a escolha
            Console.WriteLine($"\n===== Turno {currentTurn} =====");

            Monster currentPlayerMonster = currentTurn % 2 != 0 ? playerMonster : opponentMonster;
            Console.WriteLine($"É a vez de {currentPlayerMonster.Name} tomar uma ação!");

            // Mostra o menu de ações
            Console.WriteLine("\nEscolha uma ação:");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Defender");
            Console.WriteLine("3. Usar Habilidade Especial");

            string choice = Console.ReadLine();

            // Ação com base na escolha do jogador
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
                    return;  // Retorna para evitar incrementar o turno em caso de erro
            }

            // Incrementa o turno após a ação
            currentTurn++;

            // Continuar o ciclo de turnos
            PressEnterToContinue();
            StartTurn(playerMonster, opponentMonster);
        }

        private void Attack(Monster attacker, Monster defender)
        {
            // Exibe a ação e o dano causado sem limpar o status
            Console.WriteLine($"\n{attacker.Name} ataca {defender.Name}!");
            int finalDamage = defender.TakeDamage(attacker.AttackPower);
            Console.WriteLine($"{attacker.Name} causou {finalDamage} de dano!");
            Console.WriteLine($"{defender.Name} agora tem {defender.Health} de vida.");
        }

        private void Defend(Monster monster)
        {
            // Exibe a ação de defesa sem limpar o status
            Console.WriteLine($"\n{monster.Name} está se defendendo, preparando para reduzir o dano recebido!");
            // Aqui, você pode implementar a lógica de aumentar temporariamente a defesa
        }

        private void ShowMonsterStatus(Monster playerMonster, Monster opponentMonster)
        {
            // Sempre mostrar as vidas e o nome dos monstros no topo da tela
            Console.WriteLine("======================================");
            Console.WriteLine($"Player 1: {playerMonster.Name}");
            Console.WriteLine($"Vida: {playerMonster.Health}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Player 2: {opponentMonster.Name}");
            Console.WriteLine($"Vida: {opponentMonster.Health}");
            Console.WriteLine("======================================");
        }

        private void PressEnterToContinue()
        {
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
