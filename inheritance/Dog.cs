using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Dog
    {
        public int Age { get; set; }

        public string Color { get; set; }

        public Dog()
        {
            this.Age = 0;
            this.Color = "갈쌕";
        }

        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("zzzzzz"); }
        public void Bark() { Console.WriteLine("왕왕~"); }
    }
}
