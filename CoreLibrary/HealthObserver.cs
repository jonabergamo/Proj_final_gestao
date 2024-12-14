using CoreLibrary.Entities;

public class HealthObserver : IObserver
{
    public void Update(Monster monster)
    {
        Console.WriteLine($"[Observer] {monster.Name} agora tem {monster.Health} pontos de vida.");
    }
}