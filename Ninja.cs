using System;

namespace WizardNinjaSamurai
{
    
    class Ninja : Human
    {
        public Ninja(string _name, int _health) : base(_name, _health)
        {
            this.Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 3;  
            Random r = new Random();
            if(r.Next(6)==1)
            {
                dmg+= 10;
            }
            target.Health += dmg; // heals the wizard by the amount of damage dealth
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public void Steal(Human _target){
            _target.Health-= 5;
            this.Health += 5;
        }
    }
}