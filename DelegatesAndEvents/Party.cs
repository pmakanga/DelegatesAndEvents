using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Party
    {
        public void Cheering (int points)
        {
            Console.WriteLine($"Woooohooo! you've got freaking {points} points, dude!");
        }
    }
}
