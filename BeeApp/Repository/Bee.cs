using System;

namespace BeeApp.Repository
{
    public abstract class Bee
    {
        public string _name ;

        // which is not writable externally, so set it to private
        public float health { get; private set; }

        // should be readable from each bee
        public bool dead { protected get; set; }

        public int _healthLevel;
        public Bee(string name,int healthLevel)
        {
            _name = name;
            health = 100;
            dead = false;
            _healthLevel = healthLevel;
        }

        public void Damage(int damageValue)
        {
            // if damage value is out of bounds no damage is done to health
            if (!dead && damageValue > 0 && damageValue < 100)
            {
                health -= damageValue;
            }

            if (health < _healthLevel)
            {
                dead = true;
            }

            // if health becomes negative after applying damage
            if (health < 0)
            {
                health = 0;
            }
        }

        public void Display()
        {
            Console.WriteLine("Bee - {0} , Health - {1}, Is Dead - {2}", _name, health, dead);
        }

        //method to display details on web page
        public string DisplayValue()
        {
            return String.Format("Bee - {0} , Health - {1}, Is Dead - {2}", _name, health, dead);
        }
    }
}
