using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arrayToTest = new int[17];
            arrayToTest[0] = 25;
            arrayToTest[1] = 14;
            arrayToTest[2] = 42;
            arrayToTest[3] = 33;
            arrayToTest[4] = 8;
            arrayToTest[5] = 11;
            arrayToTest[6] = 1;
            arrayToTest[7] = 3;
            arrayToTest[8] = 3;
            arrayToTest[9] = 3;
            arrayToTest[10] = 3;
            arrayToTest[11] = 3;
            arrayToTest[12] = 3;
            arrayToTest[13] = 3;
            arrayToTest[14] = 3;
            arrayToTest[15] = 3;
            arrayToTest[16] = 3;

            var SortingObj = new MergeSortManager();

            Console.WriteLine("Before Sort");

            foreach (var item in arrayToTest)
            {
                Console.WriteLine(item);
            }

            SortingObj.MergeSort(arrayToTest, 0, (arrayToTest.Length - 1));

            Console.WriteLine("--------");
            Console.WriteLine("After Sort");
            Console.WriteLine("--------");

            foreach (var item in arrayToTest)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MergeSortManager 
    {
        public void MergeSort(int[] arrayToSort, int initialIndex, int endIndex) 
        {
            if (initialIndex < endIndex)
            {
                int midPoint = (initialIndex + endIndex) / 2;

                MergeSort(arrayToSort, initialIndex, midPoint);
                MergeSort(arrayToSort, midPoint + 1, endIndex);

                Merge(arrayToSort, initialIndex, midPoint, endIndex);
            }
        }

        private void Merge(int[] arrayToSort, int initialIndex, int middlePoint, int endIndex) 
        {
            //Here we use initialIndex to go though the left list until middelPoint and endInde to go thorugh the right list.
            //right list starts on middlepoint + 1
            int i = initialIndex;
            int j = middlePoint + 1;
            int k = initialIndex;

            int[] tempArray = new int[endIndex+1];

            //Here the algorithm check in wich list is the min element and the assign that element to the tempArray
            //K is always increment to prepare the temp array for recieving the next item.
            while (i <= middlePoint && j <= endIndex) 
            {
                if (arrayToSort[i] <= arrayToSort[j])
                {
                    tempArray[k] = arrayToSort[i];
                    i++;
                }
                else 
                {
                    tempArray[k] = arrayToSort[j];
                    j++;
                }

                k++;
            }
            //How next 2 loops works without crasing the program. It's simple.
            //In the previous loop we are incrementing the the index of the left half or the right half.
            // that loop will work until one of the 2 half is completly run, so the index of the one that is completly rerun
            // will be greater that the middlePoint or than the endIndex because of the increase of the items.
            //Next code will never crash because when one of the index is greater that middle or end the loop end
            //and we check that in the next 2 loops


            //Copying the remaining elements of first half, if the are any
            while (i <= middlePoint) 
            {
                tempArray[k] = arrayToSort[i];
                i++;
                k++;
            }

            //Copying the remaining elements of second half, if the are any
            while (j <= endIndex) 
            {
                tempArray[k] = arrayToSort[j];
                j++;
                k++;
            }

            //copyng the temp array to original array
            for (int z = initialIndex; z <= endIndex; z++)
            {
                arrayToSort[z] = tempArray[z];
            }
        }

    }

}
