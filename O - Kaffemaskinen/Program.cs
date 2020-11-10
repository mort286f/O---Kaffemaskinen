using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O___Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine(5);
            TeaMachine teaMachine = new TeaMachine(3);
            Console.WriteLine("Coffee or tea?");
            Console.WriteLine("(1) Coffee");
            Console.WriteLine("(2) Tea");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Which type of coffee would you like to brew?");
                Console.WriteLine("Type (1) to use " + TeaType.EarlGrey);
                Console.WriteLine("Type (2) to use " + TeaType.Raspberry);
                int coffeeInput = int.Parse(Console.ReadLine());
                if (coffeeInput == 1)
                {
                    teaMachine.TeaType = TeaType.EarlGrey;
                    teaMachine.InsertType();
                }
                else if (coffeeInput == 2)
                {
                    teaMachine.TeaType = TeaType.Raspberry;
                    teaMachine.InsertType();
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
                Console.WriteLine(coffeeMachine.Brew());
            }
            else if (input == 2)
            {
                Console.WriteLine("Which type of tea would you like to brew?");
                Console.WriteLine("Type (1) to use " + TeaType.EarlGrey);
                Console.WriteLine("Type (2) to use " + TeaType.Raspberry);
                int teaInput = int.Parse(Console.ReadLine());
                if (teaInput == 1)
                {
                    teaMachine.TeaType = TeaType.EarlGrey;
                }
                else if (teaInput == 2)
                {
                    teaMachine.TeaType = TeaType.Raspberry;
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
                Console.WriteLine(teaMachine.Brew());
            }
            else if (input == 3)
            {
                Console.WriteLine("Which type of espresso would you like to brew?");
                Console.WriteLine("Type (1) to use " + EspressoType.NormalEspresso);
                int espInput = int.Parse(Console.ReadLine());
                if (espInput == 1)
                {
                    teaMachine.TeaType = TeaType.EarlGrey;
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
                Console.WriteLine(teaMachine.Brew());
            }
            Console.ReadLine();
        }
    }
}
