using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_45
{
    public class Snake : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Snake slithers");
        }

        public override void Breathe()
        {
            Console.WriteLine("Snake is breathing");
        }
    }
}
