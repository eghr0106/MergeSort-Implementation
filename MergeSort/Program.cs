using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToTest = new int[17];
            arrayToTest[0] = 25;
            arrayToTest[1] = 14;
            arrayToTest[2] = 42;
            arrayToTest[3] = 33;
            arrayToTest[4] = 8;
            arrayToTest[5] = 11;
            arrayToTest[6] = 1;
            arrayToTest[7] = 3;       
            

            Console.WriteLine("Before Sort");

            foreach (var item in arrayToTest)
            {
                Console.WriteLine(item);
            }

            MergeSortManager.MergeSort(arrayToTest, 0, (arrayToTest.Length - 1));

            Console.WriteLine("--------");
            Console.WriteLine("After Sort");
            Console.WriteLine("--------");

            foreach (var item in arrayToTest)
            {
                Console.WriteLine(item);
            }
        }
    }

}
