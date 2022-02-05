using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_shpCreatingMethods
{
    public class MathFunction {

        public int AddNumbers(params int[] numbers) {

            var intTotal = 0;

            foreach (var number in numbers)
            {
                intTotal = intTotal + number;
            }

            return intTotal;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Sum1 = new MathFunction();
            var MySum = Sum1.AddNumbers(1,2,3,4,5);
            Console.WriteLine(MySum);
            Console.ReadLine(); 

        }
    }
}
