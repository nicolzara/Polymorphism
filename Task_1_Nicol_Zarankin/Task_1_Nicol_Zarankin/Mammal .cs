using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Mammal : Animal
    {
        protected int caloriesInMilk;
        protected int monthsOfPregnancy;

        public Mammal (string name, int age, bool isPredatorOn, int calories, int caloriesInMilk, int monthsOfPregnancy) : base(name, age, isPredatorOn, calories)
        {
            this.caloriesInMilk = caloriesInMilk;
            this.monthsOfPregnancy = monthsOfPregnancy;
        }

        public new int Eat()
        {
            return base.Eat() + caloriesInMilk;
        }

        public int GetCaloriesInMilk()
        {
            return this.caloriesInMilk;
        }

        public int GetMonthsOfPregnancy()
        {
            return this.monthsOfPregnancy;
        }

        public void SetCaloriesInMilk(int caloriesInMilk)
        {
            this.caloriesInMilk = caloriesInMilk;
        }

        public void SetMonthsOfPregnancy(int monthsOfPregnancy)
        {
            this.monthsOfPregnancy = monthsOfPregnancy;        
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Mammal: {{calories in milk: {this.caloriesInMilk.ToString()}, months of pregnancy: {this.monthsOfPregnancy.ToString()}}}";
            return info;
        }
    }
}
