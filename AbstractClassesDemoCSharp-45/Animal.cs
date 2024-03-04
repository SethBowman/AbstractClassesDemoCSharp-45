using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_45
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Stubbed out methods
        //When using the abstract keyword, you will be forcing the user to define what the method does
        //The stubbed out method only enforces that the child classes must tell it how it works
        public abstract void Move();

        //Non stubbed out
        //When using the virtual keyword you can have some default implementation for the method and just use that instead
        public virtual void Breathe()
        {
            Console.WriteLine("Animal is breathing");
        }
    }
}
