using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace examen
{
    public abstract class Situation
    {
        // Texto que muestra la situación
        public string Description { get; set; }


        // Constructor
        public Situation(string description)
        {
            Description = description;
        }


        // Toda situación debe tener Execute para que pase
        public abstract bool Execute(Player player);
    }
}