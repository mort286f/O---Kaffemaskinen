using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O___Kaffemaskinen
{
    //Derives from the generic drink machine, and represents a coffee machine
    class CoffeeMachine : DrinkMachine
    {
        private double waterAmount;
        public override double WaterAmount
        {
            get { return waterAmount; }
            protected set { waterAmount = value; }
        }
        private int beanAmount;
        public int BeanAmount
        {
            get { return beanAmount; }
            set { beanAmount = value; }
        }
        private int cupAmount;
        public override int CupAmount
        {
            get { return cupAmount; }
            protected set { cupAmount = value; }
        }
        private DrinkType type;
        public override DrinkType Type
        {
            get { return type; }
            protected set { type = value; }
        }
        private CoffeeType coffeeType;
        public CoffeeType CoffeeType
        {
            get { return coffeeType; }
            set { coffeeType = value; }
        }
        private bool isFilterInserted;

        public bool IsFilterInserted
        {
            get { return isFilterInserted; }
            set { isFilterInserted = value; }
        }


        public CoffeeMachine(int cupAmount) : base(cupAmount)
        {
            this.Type = DrinkType.Coffee;
            this.WaterAmount = 200;
            this.BeanAmount = 15;
        }

        //Fills water in the machine equal to the amount of cups
        public override double FillWater()
        {
            return WaterAmount * CupAmount;
        }

        //inserts filter
        public void InsertFilter()
        {
            IsFilterInserted = true;
        }

        //Insert a type of drink in the machine and ouput an amount of cups
        public override int InsertType()
        {
            if (CoffeeType == CoffeeType.Beans)
            {
                return BeanAmount * CupAmount;
            }
            else if (CoffeeType == CoffeeType.Capsules)
            {
                return 1 * CupAmount;
            }
            return 0;
        }
        public override string Brew()
        {
            FillWater();
            InsertFilter();
            InsertType();
            return "You have now brewed " + CupAmount + " cup(s) of coffee using " + CoffeeType;
        }
    }
}
