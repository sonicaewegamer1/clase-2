using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace examen
{
    public class Player : IEntity
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Damage { get; set; }

        public List<Item> Inventory { get; set; } //lista de inventario


        public Player(string name)
        {
            Name = name;
            Health = 30;
            Damage = 5;
            Inventory = new List<Item>();//agrega la lista de inventario para agarrar un item pero no lo pone perse
        }


        public void Attack(IEntity target)
        {
            target.Health -= Damage;

            Console.WriteLine(
                Name + " ¡Atacas! "
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
        public void AddItem(Item item)//agrega item  de verdad a la lista (creo, voy a probarlo ahora)
        {
            Inventory.Add(item);
        }
    }
}