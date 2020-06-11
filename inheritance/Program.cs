using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dog = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> cat = new List<Cat>() { new Cat(), new Cat(), new Cat() };


            foreach (var item in dog)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in cat)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

        }

    }
}
