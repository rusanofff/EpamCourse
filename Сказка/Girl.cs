using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Girl : Human, IMovable
    {
        private int age;

        public Girl(int age) : base("Девочка", age)
        {
            
        }

        public override int Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                {
                    throw new Exception($"Девочка не может быть старше 18 лет.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public override void Answer()
        {
            Console.WriteLine($"— Ах, батюшка! — отвечает девочка. — Меня мачеха посылала к своей сестре," +
                $" а сестра ее — баба-яга, костяная нога. Она меня съесть хотела. Насилу я от нее убежала!");
        }

        public override void Hello()
        {
            Console.WriteLine("— Здравствуй, тетушка! — говорит девочка.");
        }

        public override void Weave()
        {
            Console.WriteLine("\tВот девочка села у окна и стала ткать.");
        }

        void IMovable.Run()
        {
            Console.WriteLine("\tА девочка бежит что есть мочи. Бежит и не оглядывается.");
        }

        public void HairComb()
        {
            Console.WriteLine("\tДостала девочка гребень и бросила через правое плечо. Вырос тут лес, дремучий да высокий:" +
                " корни у деревьев на три сажени под землю уходят, вершины облака подпирают.");
        }

        public void Towel()
        {
            Console.WriteLine("\tВзяла девочка полотенце и бросила через правое плечо. В тот же миг разлилась река" +
                " — широкая-преширокая, глубокая-преглубокая!");
        }

        public override void Housemaid()
        {
            Console.WriteLine("\tДевочка услыхала эти слова — сидит ни жива, ни мертва. Как ушла баба-яга, она стала просить работницу:" +
                "\n— Родимая моя!Ты не столько дрова в печи поджигай, сколько водой заливай, а воду решетом носи! — И ей подарила платочек.");
        }

        public void Cause(string ch)
        {
            Console.WriteLine($"— Меня мачеха послала попросить {ch} иголочку и ниточку — мне рубашку сшить.");
        }

        public void Cat()
        {
            Console.WriteLine($"\tБаба-яга опять спать легла, а девочка дала коту мясца и спрашивает:" +
                $"— Котик - братик, научи, как мне убежать отсюда.");
        }

        public void Thank(string y)
        {
            Console.WriteLine($"- Спасибо тебе, {y}! - сказала девочка и пошла дальше.");
        }
    }
}
