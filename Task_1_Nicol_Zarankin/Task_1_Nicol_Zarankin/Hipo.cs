using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Hipo : Mammal
    {
        protected int fatPercentage;

        public Hipo(string name, int age, bool isPredatorOn, int calories, int caloriesInMilk, int monthsOfPregnancy, int fatPercentage) : base(name, age, isPredatorOn, calories, caloriesInMilk, monthsOfPregnancy)
        {
            this.fatPercentage = fatPercentage;
        }

        public int GetFatPercentage()
        {
            return this.fatPercentage;
        }

        public void SetFatPercentage(int fatPercentage)
        {
            this.fatPercentage = fatPercentage;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Hipo: {{fat percentage: {this.fatPercentage.ToString()}}}";
            return info;
        }
    }
}
