using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    abstract class Character 
    {
        public static string Name { get;  set; }

        public Character(string name)
        {
            Name = name;
        }

        public virtual void Say() { }

        public virtual void Answer()
        {
            Console.WriteLine("— Тку, тетушка, тку, милая!");
        }

        public virtual void Hello()
        {
            Console.WriteLine("- Здравствуй!");
        }

        public virtual void Ask() { }

        public virtual void Weave() { }

        public virtual void Housemaid() { }
    }
}
