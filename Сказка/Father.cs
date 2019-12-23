using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    class Father : Human, IMovable
    {
        private int age;

        public Father(int age) : base("Отец", age)
        {

        }

        public override int Age
        {
            get { return age; }
            set
            {
                if (value < 25)
                {
                    throw new Exception($"Отец не может быть младше 25 лет.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public override void Ask()
        {
            Console.WriteLine("— Где ты была, дочка? — спрашивает отец.");
        }

        void IMovable.Move()
        {
            Console.WriteLine("\tВот однажды уехал отец куда-то надолго.");
        }

        public void Concern()
        {
            Console.WriteLine("\tЗабеспокоился отец, хотел было идти дочку искать, а дочка домой прибежала, запыхалась, отдышаться не может.");
        }

    }
}
