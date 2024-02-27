using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaWeightCalculator
{
    //test value
    //h=176 , w   => 63
    //h=170 , m   => 65
    //any char =>   0
    internal class Program
    {
        static void Main(string[] args)
        {
            weightcalculator wightcalculator = new weightcalculator()
            {
                height = 176,
                gender = 'w'
            };
            double weight = wightcalculator.GetIdealWeight();
            Console.WriteLine($"the total weight is : {weight}");


            if (weight== 63)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Test succeced");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("test failed");
            }

            //wightcalculator wightcalculator2 = new wightcalculator()
            //{
            //    height = 170,
            //    gender = 'm'
            //};
            //double weight2 = wightcalculator2.GetIdealWeight();
            //Console.WriteLine($"the total weight is : {weight2}");

            // wightcalculator wightcalculator3 = new wightcalculator()
            //{
            //    height = 170,
            //    gender = 'f'
            //};
            //double weight3 = wightcalculator3.GetIdealWeight();
            //Console.WriteLine($"the total weight is : {weight3}");
            Console.ReadKey();



        }
    }
}
