using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    public static class MergeSortManager
    {
        public static void MergeSort(int[] arrayToSort, int initialIndex, int endIndex)
        {
            if (initialIndex < endIndex)
            {
                int midPoint = (initialIndex + endIndex) / 2;

                MergeSort(arrayToSort, initialIndex, midPoint);
                MergeSort(arrayToSort, midPoint + 1, endIndex);

                Merge(arrayToSort, initialIndex, midPoint, endIndex);
            }
        }

        private static void Merge(int[] arrayToSort, int initialIndex, int middlePoint, int endIndex)
        {
            int i = initialIndex;
            int j = middlePoint + 1;
            int k = initialIndex;

            int[] tempArray = new int[endIndex + 1];

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
