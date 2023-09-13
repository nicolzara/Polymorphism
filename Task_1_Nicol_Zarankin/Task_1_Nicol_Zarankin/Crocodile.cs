using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Crocodile : Reptile
    {
        protected bool dentalCare;

        public Crocodile(string name, int age, bool isPredatorOn, int calories, int tailLength, bool dentalCare) : base(name, age, isPredatorOn, calories, tailLength)
        {
            this.dentalCare = dentalCare;
        }

        public bool GetDentalCare()
        {
            return this.dentalCare;
        }

        public void SetDentalCare(bool dentalCare)
        {
            this.dentalCare = dentalCare;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Crocodile: {{had dental care: {this.dentalCare.ToString()}}}";
            return info;
        }
    }
}
