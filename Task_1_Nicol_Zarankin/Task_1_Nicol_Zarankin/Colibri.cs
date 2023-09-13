using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Colibri : Bird
    {
        protected string violetearType;

        public Colibri(string name, int age, bool isPredatorOn, int calories, int flightAltitude, int wingspanLength, string violetearType) : base(name, age, isPredatorOn, calories, flightAltitude, wingspanLength)
        {
            this.violetearType = violetearType; 
        }

        public string GetVioletearType()
        {
            return this.violetearType;
        }

        public void SetVioletearType(string violetearType)
        {
            this.violetearType = violetearType;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Colibri: {{violetear type: {this.violetearType}}}";
            return info;
        }
    }
}
