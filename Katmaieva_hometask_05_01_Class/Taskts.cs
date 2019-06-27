using System;
using ClassLibrary1;

namespace Katmaieva_hometask_05_Class
{
    class Tasks
    {
        static void Main(string[] args)
        {
            //Задание 1
            int[] array = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            for (int i=0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            IndexLibrary array1 = new IndexLibrary(array, 15);                  //sets a new start index

            int length1 = array1.LengthOfArray;
            Console.WriteLine("The length of the array:"+ length1);

            int firstIndex1 = array1.LowerBoundry;
            Console.WriteLine("The fist index of the array is:" + firstIndex1);

            int lastIndex1 = array1.UpperBoundry;
            Console.WriteLine("The last index of the array is:" + lastIndex1);

            int elementValue1 = array1[18];
            Console.WriteLine("The elementValue indexer of the array is:" + elementValue1);

            //Задание 2
            int[] array2 = { 11, 5, 5, 5 };
            int[] array3 = { -1, -3, -4, 10 };

            Polynomial p1 = new Polynomial (array2);

            Console.WriteLine(p1.ToString());


            Polynomial p2 = new Polynomial(array3);

            Console.WriteLine(p2.ToString());

            Polynomial sum = p1 + p2;

            Console.WriteLine(sum.ToString());

            Polynomial minus = p1 - p2;

            Console.WriteLine(minus.ToString());

            Polynomial multiply = p1 * p2;

            Console.WriteLine(multiply.ToString());

            Console.ReadKey();


        }
    }
}
