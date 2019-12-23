using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Housemaid : Human, IServantofBabaYaga
    {
        BabaYaga IServantofBabaYaga.baba { get; set; }
        string IServantofBabaYaga.Bribe { get; } = "Платочек";
        public string Height { get; set; }
        public override int Age { get; set; }

        public Housemaid(int age) : base("Работница", age) { }

        string IServantofBabaYaga.Reproach()
        {
            return "\tСтала баба-яга ругать работницу:" +
                "\n— Что же ты, такая-сякая, меня не разбудила, не позвала? Почему ее выпустила?" +
                "\n\tРаботница говорит:" +
                "\n— Я тебе столько лет служу — никогда слова доброго от тебя не слыхала, а она платочек мне подарила, хорошо да ласково со мной разговаривала!";
        }

        public override void Answer()
        {
            base.Answer();
        }

        string IServantofBabaYaga.Skip() { return ""; }
    }
}
