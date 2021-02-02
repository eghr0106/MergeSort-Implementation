# MergeSort-Implementation
Simple c# implementation of Merge Sort Algorithm



Below a short explanation of the magic code



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
