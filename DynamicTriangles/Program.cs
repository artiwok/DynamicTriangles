using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic Triangles:

            // *
            // **
            // ***

            Console.Write("Enter height_1: ");

            int height_1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < height_1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();


            // ***
            // **
            // *

            Console.Write("Enter height_2: ");

            int height_2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < height_2; i++)
            {
                for (int j = height_2; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();


            //   *
            //  **
            // ***

            Console.Write("Enter height_3: ");

            int height_3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height_3; i++)
            {
                for (int j = height_3; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();


            // Version 1:
            // ***
            //  **
            //   *

            Console.Write("Enter height_4: ");

            int height_4 = int.Parse(Console.ReadLine());

            for (int i = 0; i < height_4; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int j = 1; j < height_4; j++)
            {

                for (int k = 0; k < j; k++)
                {
                    Console.Write(" ");
                }

                for (int m = height_4; m > j; m--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            // Version 2:
            // ***
            //  **
            //   *

            Console.Write("Enter height_5: ");

            int height_5 = int.Parse(Console.ReadLine());

            for (int i = 0; i < height_5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = height_5; k > i; k--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
