using System;

namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        public Wizard(string _name, int _health = 50) : base(_name, _health)
        {
            this.Intelligence = 25;
        }
        public override int Attack(Human target)
        {
            int dmg = this.Intelligence * 5;
            // this.Intelligence = this.Intelligence - 5;   //reduces the barget by 5 * intelligence
            target.Health += dmg; // heals the wizard by the amount of damage dealth
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public void Heal()
        {
            this.Health = 10 * this.Intelligence;
        }
    }
}