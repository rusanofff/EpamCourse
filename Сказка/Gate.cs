using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Gate : Character, IServantofBabaYaga
    {
        BabaYaga IServantofBabaYaga.baba { get; set; }
        string IServantofBabaYaga.Bribe { get; } = "Маслицо";
        public string Width { get; set; }
        public string Material { get; set; }

        public Gate() : base("Ворота") { }

        string IServantofBabaYaga.Reproach()
        {
            return "\tПодбежала баба-яга к воротам:" +
                "\n— Почему не скрипели, почему не хлопали? Зачем девчонку со двора выпустили?" +
                "\n\tВорота говорят:" +
                "\n— Мы тебе столько лет служим, ты нам и водицы под пяточки не подлила, а она нам маслица не пожалела!";
        }

        string IServantofBabaYaga.Skip()
        {
            return "\tВорота заскрипели, хотели было захлопнуться — а девочка подлила им под пяточки маслица. Они ее и пропустили.";
        }
    }
}
