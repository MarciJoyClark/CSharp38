using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOptional
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I would like 2 numbers, though I don't require the second. Enter the first, now.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great! Now a second (or not!)");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int variable = Option.option(userInput);
            int variable2 = Option.option2(userInput2);
            Console.WriteLine("Your first number times 2 = " + variable +".  Your second (if you gave one) times 10 = " + variable2 + ".");           
            Console.ReadLine();
        }
    }
}
