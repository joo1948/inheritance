using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Dog : Animal
    {


        public string Color { get; set; }

        public Dog()
        {

        }

        public void Bark() { Console.WriteLine("왕왕~"); }
    }
}
