using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceroller
{
    class Diceroller
    {

        public void Roll() // rolling 1D6
        {
            Console.WriteLine(StaticRandom.Instance.Next(1, 7));
        }
        public void Roll(int times = 0)
        {
            int[] total = new int[times];
            for(int i = 0; i < times; ++i)
            {
                total[i] += StaticRandom.Instance.Next(1, 7);
                Console.WriteLine(total[i]);
            }
        }
        public void Roll(int times = 0, int sides = 0)
        {
            int[] total = new int[times];
            for (int i = 0; i < times; ++i)
            {
                total[i] += StaticRandom.Instance.Next(1, sides);
                Console.WriteLine(total[i]);
            }
        }
        public void Roll(int times = 0, int sides = 0, int target = 0)
        {
            int counter = 0;
            int[] total = new int[times];
            for (int i = 0; i < times; ++i)
            {
                total[i] += StaticRandom.Instance.Next(1, sides);
                if(total[i] >= target)
                    counter++;

            }
                Console.WriteLine(counter);
        }
    }
}
