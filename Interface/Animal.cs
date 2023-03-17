using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
          
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
