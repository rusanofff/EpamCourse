using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Stepmother : Human, IBadCharacter
    {
        private int age;

        public Stepmother(int age) : base("Мачеха", age)
        {

        }

        public override int Age
        {
            get { return age; }
            set
            {
                if (value < 25)
                {
                    throw new Exception($"Мачеха не может быть младше 25 лет.");
                }
                else
                {
                    age = value;
                }
            }
        }

        void IBadCharacter.GetAngry()
        {
            Console.WriteLine($"\tНевзлюбила злая баба девочку, била ее, ругала, только и думала, как бы совсем извести, погубить.");
        }

        void IBadCharacter.Die()
        {
            Console.WriteLine($"\tКак узнал все это отец, рассердился он на злую бабу и выгнал ее грязным помелом вон из дому." +
                $" \nНе выдержала мачеха долго без крыши над головой, да померла скоро.");
        }

        void IBadCharacter.Lie()
        {
            Console.WriteLine($"\tA мачеха и говорит девочке:" +
                $"\n— Поди к моей сестре, твоей тетке, попроси у нее иголку да нитку — тебе рубашку сшить.");
        }

        public override void Ask()
        {
            Console.WriteLine("\tВечером вернулся домой отец и спрашивает у жены:" +
                "\n— А где же моя дочка ? ");
        }

        public override void Answer()
        {
            Console.WriteLine("\tБаба говорит:" +
                "\n— Она к тетушке пошла — иголочку да ниточку попросить, да вот задержалась что-то.");
        }
    }
}
