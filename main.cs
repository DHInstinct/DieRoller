using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceroller
{
    class main
    {
        static void Main(string[] args)
        {
            Diceroller diceroller = new Diceroller();

           Console.WriteLine("Rolling D6:");
           diceroller.Roll();
           Console.WriteLine("Rolling D6 10 times:");
           diceroller.Roll(10);
           Console.WriteLine("Rolling D10 10 times:");
           diceroller.Roll(10,10);
           Console.WriteLine("Rolling D10 10 times with a target of 5:");
           diceroller.Roll(10, 10, 5);






        }
    }
}
