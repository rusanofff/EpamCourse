using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    abstract class Human : Character, IMovable
    {
        public abstract int Age { get; set; }

        public Human(string name, int age) : base(name)  {
            Age = age;
        }

        //public void Say() { }

        public void Move() { }

        public void Run() { }

       
    }
}
