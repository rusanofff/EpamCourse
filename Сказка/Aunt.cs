using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Aunt : Human
    {
        private int age;

        public Aunt(int age) : base("Тётушка", age)
        {

        }

        public override int Age
        {
            get { return age; }
            set
            {
                if (value < 25)
                {
                    throw new Exception($"Тётушка не может быть младше 25 лет.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public void Say()
        {
            Console.WriteLine($"— Хорошо, племянница, что ты прежде ко мне зашла, — говорит тетка." +
                $" \n— Вот тебе ленточка, масло, хлебец да мяса кусок. Будет там тебя березка в глаза стегать — ты ее ленточкой перевяжи;" +
                $" \nбудут ворота скрипеть да хлопать, тебя удерживать — ты подлей им под пяточки маслица;" +
                $" \nбудут тебя собаки рвать — ты им хлебца брось; будет тебе кот глаза драть — ты ему мясца дай.");
        }

        public override void Hello()
        {
            Console.WriteLine("— Здравствуй, родимая! Зачем пришла?");
        }
    }
}
