using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class Enemy : IEntity
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Damage { get; set; }
        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public void Attack(IEntity target)
        {
            target.Health -= Damage;

            Console.WriteLine(
                Name + " ataca y hace "
                + Damage + " de daño."
            );

            Console.WriteLine(
                target.Name + " tiene "
                + target.Health + " de vida."
            );
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}