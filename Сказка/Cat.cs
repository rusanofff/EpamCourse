using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Cat : Animal, IServantofBabaYaga
    {
        BabaYaga IServantofBabaYaga.baba { get; set; }
        public const string Nickname = "Котик-братик";
        string IServantofBabaYaga.Bribe { get; } = "Мясо";
        

        public Cat() : base("Кот") { }

        string IServantofBabaYaga.Reproach()
        {
            return "\tПринялась баба-яга бить да ругать кота:" +
                "\n— Ах ты, старый плут!Ах ты, злодей!Зачем выпустил девчонку ? Почему глаза ей не выдрал ? Почему лицо не поцарапал?" +
                "\n\tА кот ей в ответ:" +
                "\n— Я тебе столько лет служу, ты мне косточки обглоданной не бросила, а она мне мясца дала!";
        }

        public override void Say()
        {
            Console.WriteLine($"\tКот говорит:" +
                $"\n— Вон на столе лежит полотенце да гребешок, возьми их и беги поскорее: не то баба - яга съест!" +
                $"\nБудет за тобой гнаться баба - яга — ты приложи ухо к земле.Как услышишь, что она близко," +
                $"\n брось гребешок — вырастет густой дремучий лес.Пока она будет сквозь лес продираться, ты далеко убежишь." +
                $"\nА опять услышишь погоню — брось полотенце: разольется широкая да глубокая река.");
        }

        public override void Weave()
        {
            Console.WriteLine("\tА кот тем временем сел у окна и принялся ткать. Не столько ткет, сколько путает!");
        }

        string IServantofBabaYaga.Skip() { return ""; }

       
    }
}
