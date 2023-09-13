using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Animal
    {
        protected string name;
        protected int age;
        protected bool isPredatorOn;
        protected int calories;

        public Animal(string name, int age, bool isPredatorOn, int calories)
        {
            this.name = name;
            this.age = age; 
            this.isPredatorOn = isPredatorOn;   
            this.calories = calories;
        }

        public int Eat()
        {
            return this.calories * 3;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public bool GetIsPredatorOn()
        {
            return this.isPredatorOn;
        }

        public int GetCalories()
        {
            return this.calories;
        }
            
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetIsPredatorOn(bool isPredatorOn)
        {
            this.isPredatorOn = isPredatorOn;
        }

        public void SetCalories(int calories)
        {
            this.calories = calories;
        }

        public override string ToString()
        {
            string info = $"{{Animal: {{name: {this.name}, age: {this.age.ToString()}, is predator on: {this.isPredatorOn.ToString()}, calories per meal: {this.calories.ToString()}}}";
            return info;
        }
    }
}
