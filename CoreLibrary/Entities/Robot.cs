namespace CoreLibrary.Entities
{
    public class Robot : Monster
    {
        private bool defending { get; set; }
        public Robot(string name, int attack, int defense, int health) : base(name, attack, defense, health)
        {
            base.AbilityName = "Escudo Biônico";
            defending = false;
        }


        public override void SpecialAbility()
        {
            defending = true;
        }

        public override int TakeDamage(int damage)
        {
            if (defending)
            {
                this.defending = false;
                return 0;
            }
            int finalDamage = Math.Max(0, damage - Defense);
            Health -= finalDamage;

            return finalDamage;
        }
    }
}
