using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Bird : Animal, IBird
    {
        protected int flightAltitude;
        protected int wingspanLength;

        public Bird(string name, int age, bool isPredatorOn, int calories, int flightAltitude, int wingspanLength) : base(name, age, isPredatorOn, calories)
        {
            this.flightAltitude = flightAltitude;
            this.wingspanLength = wingspanLength;
        }

        public void Rise()
        {
            Console.WriteLine( "🛫");
        }

        public void Land()
        {
            Console.WriteLine( "🛬");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }


        public string Sing()
        {
            return "twit twit";
        }

        public void Dance()
        {
            Console.WriteLine("I'm dancing look at me!!!");
        }

        public int GetFlightAltitude()
        {
            return this.flightAltitude;
        }

        public int GetWingspanLength() 
        { 
            return this.wingspanLength;
        }

        public void SetFlightAltitude(int flightAltitude)
        {
            this.flightAltitude = flightAltitude;
        }

        public void SetWingspanLenght(int wingspanLength)
        {
            this.wingspanLength = wingspanLength;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Bird: {{flight altitude: {this.flightAltitude.ToString()}, wingspan length: {this.wingspanLength.ToString()}}}";
            return info;
        }
    }
}
