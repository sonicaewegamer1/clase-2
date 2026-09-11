using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class Combat : Situation
    {
        Enemy enemy;

        public Combat(string desc, Enemy enemy)
            : base(desc)
        {
            this.enemy = enemy;
        }

        public override bool Execute(Player player)
        {
            Console.WriteLine(Description);

            bool blocking = false;     // si está bloqueando
            bool canBlock = true;      // regla: no puede bloquear dos turnos seguidos

            while (player.IsAlive() && enemy.IsAlive())
            {
                Console.WriteLine("");
                Console.WriteLine("¿Que haces?");
                Console.WriteLine("1. Atacar");

                if (canBlock)
                    Console.WriteLine("2. Cubrirse");
                else
                    Console.WriteLine("2. Cubrirse (no disponible)");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    player.Attack(enemy);

                    //evita negativo visual
                    if (enemy.Health < 0)
                        enemy.Health = 0;

                    Console.WriteLine(enemy.Name + " tiene " + enemy.Health + " de vida.");

                    blocking = false;

                    //si atacas, puedes bloquear, pero debes haber atacado antes
                    canBlock = true;
                }

                else if (choice == "2")
                {
                    if (!canBlock)
                    {
                        Console.WriteLine("No puedes cubrirte dos turnos seguidos.");
                        continue;
                    }

                    Console.WriteLine("Te cubres.");
                    blocking = true;

                    // cooldown para no bloquear seguido
                    canBlock = false;
                }

                else
                {
                    Console.WriteLine("Accion invalida.");
                    continue;
                }

                // evita que se buguee al estar con vida negativa
                if (!enemy.IsAlive())
                    break;

                // turno del enemigo
                if (enemy.IsAlive())
                {
                    if (blocking)
                    {
                        Console.WriteLine("Bloqueaste el ataque del enemigo.");
                        blocking = false;
                    }
                    else
                    {
                        enemy.Attack(player);

                        // evita que se ponga en negativo visualmente
                        if (player.Health < 0)
                            player.Health = 0;
                    }
                }
            }

            return player.IsAlive();
        }
    }
}