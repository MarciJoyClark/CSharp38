using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOptional
{
    public class Option
    {
        public static int option(int number)
        {
            int newOp = number * 2;
            return newOp;
        }
        public static int option2(int optionalInt, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                while (optionalInt > 0)
                {
                    int newOp2 = optionalInt * 10;
                    return newOp2;
                }
            }
        }              
    }
}
