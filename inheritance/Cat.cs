﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Cat
    {
        public int Age { get; set; }
        
        public Cat()
        {
            this.Age = 0;
        }
        public void Eat() { Console.WriteLine("냠냠");}
        
        public void Sleep()
        {
            Console.WriteLine("zzzzzz");
        }
        public void Meow() { Console.WriteLine("냐옹"); }
    
    }
}
