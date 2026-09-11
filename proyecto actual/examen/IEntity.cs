using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public interface IEntity
    {
        string Name { get; set; }
        int Health { get; set; }
        int Damage { get; set; }

        void Attack(IEntity target);
        bool IsAlive();
    }
}