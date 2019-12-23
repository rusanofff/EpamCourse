using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Narrative
    {

        public void Start()
        {
            Console.WriteLine("\tЖили-были муж с женой, и была у них дочка. Заболела жена и умерла." +
                " \nПогоревал-погоревал мужик да и женился на другой.");
        }

        public void Story()
        {
            try
            {
                Stepmother stepmother = new Stepmother(35);
                Father father = new Father(40);
                Girl girl = new Girl(15);
                BabaYaga yaga = new BabaYaga("Избушка на курьих ножках");
                Cat cat = new Cat();
                Aunt aunt = new Aunt(36);
                Dogs dogs = new Dogs();
                Gate gate = new Gate();
                
                BirchTree birchTree = new BirchTree();
                Housemaid housemaid = new Housemaid(40);
                ((IBadCharacter)stepmother).GetAngry();
                ((IMovable)father).Move();
                ((IBadCharacter)stepmother).Lie();
                girl.Hello();
                aunt.Hello();
                girl.Cause("к своей сестре");
                aunt.Say();
                girl.Hello();
                yaga.Hello();
                girl.Cause("у тебя");
                ((IBadCharacter)yaga).Lie();
                girl.Weave();
                yaga.Housemaid();
                girl.Housemaid();
                yaga.Ask();
                housemaid.Answer();
                girl.Cat();
                cat.Say();
                girl.Thank(Cat.Nickname);
                string w = ((IServantofBabaYaga)dogs).Skip();
                string q = ((IServantofBabaYaga)gate).Skip();
                string l = ((IServantofBabaYaga)birchTree).Skip();
                List<string> list = new List<string> { w, q, l };
                MyRandom<string> myRandom = new MyRandom<string>(list);
                myRandom.Random(list);
                ((IMovable)girl).Run();
                cat.Weave();
                yaga.Ask();
                cat.Answer();
                ((IMovable)yaga).Run();
                string c = ((IServantofBabaYaga)cat).Reproach();
                string d = ((IServantofBabaYaga)dogs).Reproach();
                string g = ((IServantofBabaYaga)gate).Reproach();
                string b = ((IServantofBabaYaga)birchTree).Reproach();
                string h = ((IServantofBabaYaga)housemaid).Reproach();
                List<string> list1  = new List<string> { c, d, g, b, h };
                MyRandom<string> myRandom2 = new MyRandom<string>(list1);
                myRandom2.Random(list1);
                yaga.GetAngry();
                ((IMovable)yaga).Move();
                girl.HairComb();
                yaga.GetAngry1();
                ((IMovable)yaga).Move();
                girl.Towel();
                ((IBadCharacter)yaga).GetAngry();
                yaga.Bulls();
                ((IBadCharacter)yaga).Die();
                ((IMovable)girl).Run();
                stepmother.Ask();
                stepmother.Answer();
                father.Concern();
                father.Ask();
                girl.Answer();
                ((IBadCharacter)stepmother).Die();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка:{ex.Message}");
            }
        }

        public void End()
        {
            Console.WriteLine("\tИ стал он жить вдвоем с дочкой, дружно да хорошо. Здесь и сказке конец.");
        }
    }
}
