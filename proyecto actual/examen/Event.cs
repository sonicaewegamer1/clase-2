using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace examen
{
    public class Event : Situation
    {
        Item reward;


        public Event(string desc, Item reward)
            : base(desc)
        {
            this.reward = reward;
        }


        public override bool Execute(Player player)
        {
            Console.WriteLine(Description);

            reward.Use(player);

            return true;
        }
    }
}
