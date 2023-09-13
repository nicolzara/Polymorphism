using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Reptile : Animal, IReptile
    {
        protected int tailLength;

        public Reptile(string name, int age, bool isPredatorOn, int calories, int tailLength) : base(name, age, isPredatorOn, calories)
        {
            this.tailLength = tailLength;
        }

        public void Crawl()
        {
            Console.WriteLine("I'm crawling");
        }

        public void Defend()
        {
            Console.WriteLine("I'm defending");
        }

        public void BodyTempCheck()
        {
            Console.WriteLine("I'm checking my body temperature");
        }

        public int GetTailLength()
        {
            return this.tailLength;
        }

        public void SetTailLength(int tailLength)
        {
            this.tailLength = tailLength;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Reptile: {{tail length: {this.tailLength.ToString()}}}";
            return info;
        }
    }
}
