using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Program
    {
        static void Main(string[] args)
        {
            Narrative narrative = new Narrative();
            narrative.Start();
            narrative.Story();
            narrative.End();
            Console.ReadKey();
        }
    }
}
