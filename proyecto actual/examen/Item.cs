using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public abstract class Item : Iusable
    {
        public string Name { get; set; }

        public Item(string name)
        {
            Name = name;
        }

        public abstract void Use(Player player);
    }
}