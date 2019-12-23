using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class BirchTree : Character, IServantofBabaYaga
    {
        BabaYaga IServantofBabaYaga.baba { get; set; }
        string IServantofBabaYaga.Bribe { get; } = "Ленточка";
        public string Height { get; set; }

        public BirchTree() : base("Берёзка") { }

        string IServantofBabaYaga.Reproach()
        {
            return "\tПодскочила баба-яга к березке:" +
                "\n— Почему девчонке глаза не выстегала?" +
                "\n\tБерезка ей отвечает:" +
                "\n— Я тебе столько лет служу, ты меня ниточкой не перевязала, а она мне ленточку подарила!";
        }

        string IServantofBabaYaga.Skip()
        {
            return "\tБерезка зашумела, хотела ей глаза выстегать, — девочка ее ленточкой перевязала. Березка ее и пропустила.";
        }
    }
}
