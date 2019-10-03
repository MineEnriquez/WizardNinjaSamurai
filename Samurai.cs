using System;

namespace WizardNinjaSamurai
{
    class Samurai : Human
    {
        private int initialHealt =0;
        public Samurai(string _name, int _health = 200) : base(_name, _health)
        {
            this.initialHealt = _health;
        }
        public override int Attack(Human _target)
        {
            base.Attack(_target);
            if (_target.Health<50){
                this.Health =0;
            }
            return _target.Health;
        }

        public void Meditate(){
                this.Health = initialHealt;
        }
    }
}