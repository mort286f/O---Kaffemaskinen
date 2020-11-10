using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O___Kaffemaskinen
{
    //This class represents a generic machine that can make drinks
    public abstract class DrinkMachine
    {
        public abstract double WaterAmount { get; protected set; }
        public abstract int CupAmount { get; protected set; }
        public abstract DrinkType Type { get; protected set; }
        public abstract double FillWater();
        public abstract int InsertType();
        public abstract string Brew();
        public DrinkMachine(int cupAmount)
        {
            this.CupAmount = cupAmount;
        }
    }
}
