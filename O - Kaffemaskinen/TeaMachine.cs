using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O___Kaffemaskinen
{
    //Derives from the generic drink machine, and represents a tea machine
    class TeaMachine : DrinkMachine
    {
        private DrinkType type;
        public override DrinkType Type
        {
            get { return type; }
            protected set { type = value; }
        }

        private TeaType teaType;
        public TeaType TeaType
        {
            get { return teaType; }
            set { teaType = value; }
        }

        private double waterAmount;
        public override double WaterAmount
        {
            get { return waterAmount; }
            protected set { waterAmount = value; }
        }
        private int cupAmount;
        public override int CupAmount
        {
            get { return cupAmount; }
            protected set { cupAmount = value; }
        }
        public TeaMachine(int cupAmount) : base(cupAmount)
        {
            this.Type = DrinkType.Tea;
            this.WaterAmount = 250;
        }

        //Fills water in the machine equal to the amount of cups
        public override double FillWater()
        {
            return WaterAmount * CupAmount;
        }

        //Insert a type of drink in the machine and ouput an amount of cups
        public override int InsertType()
        {
            if (TeaType == TeaType.EarlGrey)
            {
                return 1 * CupAmount;
            }
            else if (TeaType == TeaType.Raspberry)
            {
                return 1 * CupAmount;
            }
            return 0;
        }
        public override string Brew()
        {
            FillWater();
            return "The machine finished brewing " + CupAmount + " cup(s) of " + TeaType;
        }
    }
}
