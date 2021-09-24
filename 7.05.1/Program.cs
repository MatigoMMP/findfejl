using System;

namespace _7._05._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fejlopgave 1
            int num, res, i;

            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while (i <= 1)
            {
                res = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, res);
                num++;
            }
            Console.ReadLine();
            Console.WriteLine("\n");

            // Output:
            // gange tabellen for jeres input
            // eksempel med 1 som user input
            // 1 * 1 = 1
            // 1 * 2 = 2
            // 1 * 3 = 3
            // 1 * 4 = 4
            // 1 * 5 = 5
            // 1 * 6 = 6
            // 1 * 7 = 7
            // 1 * 8 = 8
            // 1 * 9 = 9
            // 1 * 10 = 10



            // Fejlopgave 2
            int minFar = 2;
            int mitStamtræ = 100;


            for (int minFam = 0; minFam < mitStamtræ; minFam--)
            {
                if (minFam < minFar)
                {
                    minFar++;
                }
            }
            Console.WriteLine(minFar);
            Console.WriteLine("\n");

            // Output: 102




            // Fejlopgave 3
            int yeet = 0;

            while (true)
            {
                yeet = Convert.ToInt32(Console.ReadLine());
                if (yeet % 2 != 0)
                {
                    break;
                }
                Console.WriteLine("Not even number entered: {0}", yeet);
            }
            Console.WriteLine("Even number entered: {0}", yeet);
            Console.WriteLine("\n");

            // Output:
            // Fortæller om users input er et lige tal eller ulige tal
        }
    }
}
