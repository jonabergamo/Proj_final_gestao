namespace CoreLibrary.Entities
{
    public class Goblin : Monster
    {
        public Goblin(string name, int attack, int defense, int health) : base(name, attack, defense, health)
        {
            base.AbilityName = "Ataque Furtivo";
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} usa {AbilityName}, causando um ataque rápido e furtivo!");
        }
    }
}
