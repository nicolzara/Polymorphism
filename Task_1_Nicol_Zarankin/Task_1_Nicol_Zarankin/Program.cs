using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals = new Mammal[]{
                new Mammal("yeapy", 12, true, 21, 90, 92),
                new Cow("clopy", 7, false, 32, 90, 92, 2),
                new Cow("shlopy", 53, false, 79, 90, 91, 3),
                new Mammal("sneapy", 1, true, 80, 90, 92),
                new Hipo("creapy", 1127582, true, 259, 90, 92, 800)
            };
            Reptile[] reptiles = new Reptile[]{
                new Reptile("repti", 13 ,false, 90, 78),
                new Cobra("c++", 40, true, 0, 6, true, "blue"),
                new Snake("snake snake", 2, true, 80, 90, false),
                new Crocodile("croc", 100, true, 900, 500, true),
                new Cobra("c", 51, true, 0, 68, true, "blue")
            };

            Animal[] animals = new Animal[]{
                new Animal("animalMan", 16, true, 300),
                new Colibri("colibri", 37, false, 700, 50, 20, "Brown"),
                new Bird("birb", 5, false, 80, 60, 13),
                new Hipo("yeapyeap", 90, false, 1500, 300, 15, 67),
                new Crocodile("croocroo", 51, true, 3000, 60,false),
                new Snake("sniffsniff", 15, true, 2000, 70, true),
                new Mammal("animammal", 16, true, 400, 70, 9),
                new Reptile("reportile", 6, false, 70, 40)
            };
        }

        public static int CaloriesSum(Animal[] animals)
        {
            int sum = 0;

            foreach(Animal animal in animals)
            {
                sum += animal.Eat();
            }

            return sum;
        }

        public static int NumOfMammals(Animal[] animals)
        {
            int counter = 0;

            foreach (Animal animal in animals)
            {
                if (animal is Mammal)
                {
                    counter++;
                }
            }

            return counter; 
        }

        public static void DanceIfYouCan(Animal[] animals)
        {
            foreach(Animal animal in animals)
            {
                if( animal is Bird)
                {
                    ((Bird)animal).Dance();
                }
                else if(animal is Snake)
                {
                    ((Snake)animal).Dance();
                }
                
            }
        }

        public static string FatestHipo(Animal[] animals)
        {
            string fatestHipoName = "";
            int fatestHipoBodyFat = -1;

            foreach(Animal animal in animals)
            {
                if(animal is Hipo)
                {
                    if (fatestHipoBodyFat == -1)
                    {
                        fatestHipoBodyFat = ((Hipo)animal).GetFatPercentage();
                        fatestHipoName = animal.GetName();
                    }

                    else if (((Hipo)animal).GetFatPercentage() > fatestHipoBodyFat)
                    {
                        fatestHipoBodyFat = ((Hipo)animal).GetFatPercentage();
                        fatestHipoName = animal.GetName();
                    }
                }
            }

            return fatestHipoName;
        }


    }
}
