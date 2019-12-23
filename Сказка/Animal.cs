using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    abstract class Animal : Character
    {
        //public string Name { get; set; }

        public Animal(string name) : base(name)
        {
            Name = name;
        }

        public void Move()
        {

        }
    }
}
