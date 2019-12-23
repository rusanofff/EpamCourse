using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class BabaYaga : Character, IBadCharacter, IMovable
    {
        public string SmallHut { get; set; }

        public BabaYaga(string smallhut) : base("Баба-яга")
        {
            SmallHut = smallhut;
        }

        void IBadCharacter.GetAngry()
        {
            Console.WriteLine($"\tПодскочила баба-яга к реке, от злости зубами заскрипела — не может через реку перебраться.");
        }

        void IBadCharacter.Lie()
        {
            Console.WriteLine($"\t— Хорошо, племяннушка, дам тебе иголочку да ниточку, а ты садись покуда поработай, да не бойся ничего," +
                $" про меня слухи ходят гнусные, но это клевета всё.");
        }

        public void GetAngry()
        {
            Console.WriteLine("\tПокричала баба-яга, пошумела, потом села в ступу и помчалась в погоню. Пестом погоняет, помелом след заметает.");
        }

        public void GetAngry1()
        {
            Console.WriteLine("\tПримчалась баба-яга, стала грызть да ломать лес. Она грызет да ломает, а девочка дальше бежит.");
        }

        void IBadCharacter.Die()
        {
            Console.WriteLine($"\tРассердилась баба-яга, легла на берег, сама стала воду пить." +
                $"\n Пила, пила, пила, пила, до тех пор пила, пока не лопнула.");
        }

        public override void Hello()
        {
            Console.WriteLine("— Здравствуй, племянница! — говорит баба-яга. — Что тебе надобно?");
        }

        public override void Ask()
        {
            Console.WriteLine($"\tПроснулась баба-яга и спрашивает:" +
                $"\n— Ткешь ли, племяннушка, ткешь ли, милая ?");
        }

        void IMovable.Move()
        {
            Console.WriteLine("\tА девочка бежала-бежала, остановилась, приложила ухо к земле и слышит:" +
                " земля дрожит, трясется — баба-яга гонится, и уж совсем близко...");
        }

        void IMovable.Run()
        {
            Console.WriteLine("\tЗабегает баба-яга в избушку и видит — девочки нету, а кот сидит, ткет.");
        }

        public void Bulls()
        {
            Console.WriteLine("\tВоротилась она домой, собрала своих быков и погнала к реке:" +
                "\n— Пейте, мои быки!Выпейте всю реку до дна!" +
                "\n\tСтали быки пить, а вода в реке не убывает.");
        }

        public override void Housemaid()
        {
            Console.WriteLine("\tА баба-яга вышла из избушки и говорит своей работнице:" +
                "\n— Я сейчас спать лягу, а ты ступай, истопи баню и вымой племянницу.Да смотри, хорошенько вымой: проснусь — съем ее!");
        }
    }
}
