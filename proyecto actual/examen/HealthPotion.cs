using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class HealthPotion : Item
    {
        public HealthPotion() : base("poción de vida")
        {
            //basio pq llama a use
        }

        public override void Use(Player player)
        {
            player.Health += 10;
            Console.WriteLine("Ganaste 10 de vida adicional.");
        }
    }
}