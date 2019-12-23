using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class MyRandom<T>
    {
        List<T> list;

        public MyRandom(List<T> list)
        {
            this.list = list;
        }

        public void Random(List<T> list)
        {
            Random rand = new Random();
            while(list.Count > 0)
            {
                int a = rand.Next(list.Count-1);
                Console.WriteLine(list[a]);
                list.RemoveAt(a);
            }
        }
    }
}
