using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_45
{
    public class Dog : Animal
    {
        //When you have an abstract method an the child classes inherit the abstract class, you HAVE TO use the ovveride keyword
        //The override keywords gives the method or member it's value
        public override void Move()
        {
            Console.WriteLine("Dog runs");
        }
    }
}
