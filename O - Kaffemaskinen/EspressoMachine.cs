using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O___Kaffemaskinen
{
    //represents an espresso machine, which is derived from the DrinkMachine
   class EspressoMachine : DrinkMachine
    {
        private DrinkType type;
        public override DrinkType Type
        {
            get { return type; }
            protected set { type = value; }
        }
        private int cupAmount;
        public override int CupAmount
        {
            get { return cupAmount; }
            protected set { cupAmount = value; }
        }
        private double waterAmount;

        public override double WaterAmount
        {
            get { return waterAmount; }
            protected set { waterAmount = value; }
        }
        private EspressoType espressoType;

        public EspressoType EspressoType
        {
            get { return espressoType; }
            set { espressoType = value; }
        }
        private bool isFilterInserted;

        public bool IsFilterInserted
        {
            get { return isFilterInserted; }
            set { isFilterInserted = value; }
        }

        public EspressoMachine(int cupAmount) : base(cupAmount)
        {
            this.Type = DrinkType.Espresso;
            this.WaterAmount = 150;

        }

        //Fills water in the machine equal to the amount of cups
        public override double FillWater()
        {
            return waterAmount * CupAmount;
        }

        //inserts filter
        public void InsertFilter()
        {
            IsFilterInserted = true;
        }

        //Insert a type of drink in the machine and ouput an amount of cups
        public override int InsertType()
        {
            if (EspressoType == EspressoType.NormalEspresso)
            {
                return 1 * CupAmount;
            }
            return 0;
        }

        
        public override string Brew()
        {
            FillWater();
            InsertFilter();
            string brewEsp;
            for (int i = 0; i < CupAmount; i++)
            {
                brewEsp = "Finished brewing " + CupAmount + " cup(s) of " + EspressoType;
                return brewEsp;
                
            }
            return "Finished";
        }
    }
}
