using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Dogs : Animal, IServantofBabaYaga 
    {
        BabaYaga IServantofBabaYaga.baba { get; set; }
        string IServantofBabaYaga.Bribe { get; } = "Хлеб";
        public string Breed { get; set; }


        public Dogs() : base("Собаки") { }

        string IServantofBabaYaga.Reproach()
        {
            return "\tВыбежала баба-яга из избушки, накинулась на собак:" +
                "\n— Почему девчонку не рвали, почему не кусали?" +
                "\n\tСобаки ей говорят:" +
                "\n— Мы тебе столько лет служим, ты нам горелой корочки не бросила, а она нам хлебца дала!";
        }

        string IServantofBabaYaga.Skip()
        {
            return "\tБросились на нее собаки, хотели ее рвать, кусать, — она им хлеба дала. Собаки ее и пропустили.";
        }
    }
}
