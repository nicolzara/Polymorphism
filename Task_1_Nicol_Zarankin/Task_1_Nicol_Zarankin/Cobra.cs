using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Nicol_Zarankin
{
    class Cobra : Snake
    {
        protected string region;

        public Cobra(string name, int age, bool isPredatorOn, int calories, int tailLength, bool isPoisonous, string region) : base(name, age, isPredatorOn, calories, tailLength, isPoisonous)
        {
            this.region = region;
        }

        public string GetRegion()
        {
            return this.region;
        }

        public void SetRegion(string region)
        {
            this.region = region;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Cobra: {{region: {this.region}}}";
            return info;
        }
    }
}
