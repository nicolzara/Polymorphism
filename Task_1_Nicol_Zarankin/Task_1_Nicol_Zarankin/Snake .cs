using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Snake : Reptile
    {
        protected bool isPoisonous;

        public Snake(string name, int age, bool isPredatorOn, int calories, int tailLength, bool isPoisonous) : base(name, age, isPredatorOn, calories, tailLength)
        {
            this.isPoisonous = isPoisonous;
        }

        public void Dance()
        {
            Console.WriteLine("I'm dancing look at me!!!");
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Snake: {{is poisonous: {this.isPoisonous.ToString()}}}";
            return info;
        }
    }
}
