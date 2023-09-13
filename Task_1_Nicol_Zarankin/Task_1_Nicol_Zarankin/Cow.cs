using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Cow : Mammal
    {
        protected int numOfLitters;

        public Cow(string name, int age, bool isPredatorOn, int calories, int caloriesInMilk, int monthsOfPregnancy, int numOfLitters) : base(name, age, isPredatorOn, calories, caloriesInMilk, monthsOfPregnancy)
        {
            this.numOfLitters = numOfLitters;
        }

        public new int Eat()
        {
            return Convert.ToInt32(base.Eat() * 0.25);
        }

        public int GetNumOfLitters()
        {
            return this.numOfLitters;
        }

        public void SetNumOfLitters(int numOfLitters)
        {
            this.numOfLitters = numOfLitters;
        }

        public override string ToString()
        {
            string info =  base.ToString();
            info += $" Cow: {{number of litters: {this.numOfLitters.ToString()}}}";
            return info;
        }
    }
}
