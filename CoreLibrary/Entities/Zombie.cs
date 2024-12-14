namespace CoreLibrary.Entities
{
    public class Zombie : Monster
    {
        public Zombie(string name, int attack, int defense, int health) : base(name, attack, defense, health)
        {
            base.AbilityName = "Regeneração Rápida";
        }


        public override void SpecialAbility()
        {
            Console.WriteLine("testando habilidade special do zumbi");
        }
    }
}
