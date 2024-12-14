# MonstersBattleGame

## Descrição do Projeto

**MonstersBattleGame** é um jogo de console simples que simula batalhas entre monstros. Cada jogador escolhe um monstro e utiliza estratégias de combate para atacar, defender ou usar habilidades especiais até que um dos monstros seja derrotado.

O projeto foi desenvolvido com foco na aplicação de **Design Patterns** para criar um código bem estruturado, flexível e escalável.

---

## Pré-requisitos

1. **.NET SDK instalado**
   - Certifique-se de que o .NET está instalado em sua máquina.
   - Para instalar, visite o site oficial da Microsoft: [Download .NET](https://dotnet.microsoft.com/download).

2. **Git**
   - Certifique-se de ter o Git instalado para clonar o repositório.

---

## Como Executar

1. Clone o repositório do projeto:
   ```bash
   git clone https://github.com/jonabergamo/MonstersBattleGame.git


2.  Acesse o diretório do projeto:
    
    `cd MonstersBattleGame/CombatLibrary` 
    
3.  Execute o jogo:

    `dotnet run` 
    

----------

## Sobre o Jogo

No **MonstersBattleGame**, cada jogador:

-   Escolhe um monstro para a batalha.
-   Realiza ações como atacar, defender ou usar habilidades especiais.
-   Ganha ao derrotar o monstro adversário.

O jogo apresenta turnos alternados, onde cada jogador toma decisões estratégicas para vencer.

----------

## Design Patterns Aplicados

O projeto utiliza uma série de **Design Patterns** para melhorar a estrutura e a modularidade do código:

1.  **Strategy Pattern**:
    
    -   Permite alternar entre diferentes estratégias de combate dinamicamente (ataque, defesa, habilidade especial).
    -   Implementado nas classes `AttackStrategy` e `DefendStrategy`.
2.  **Singleton Pattern**:
    
    -   Garante que apenas uma instância do jogo exista durante a execução.
    -   Implementado na classe `Game`.
3.  **Composite Pattern**:
    
    -   Gerencia múltiplos monstros como uma coleção lógica pertencente a um jogador.
    -   Implementado na classe `Player`, que mantém uma lista de monstros.
4.  **Observer Pattern**:
    
    -   Monitora e reflete automaticamente mudanças no estado dos monstros (como alterações na saúde).
    -   Implementado nas classes `Monster` (observável) e `HealthObserver` (observador).
5.  **Factory Pattern**:
    
    -   Abstrai e centraliza a criação de diferentes tipos de monstros.
    -   Implementado na classe `MonsterFactory`.

----------