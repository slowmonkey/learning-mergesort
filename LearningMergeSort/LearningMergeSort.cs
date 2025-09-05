namespace MergeSort;

public class LearningMergeSort
{
    public static void MergeSort(int[] items)
    {
        // Stop processing if the number of items in the array is 1 or less

        if (items.Length <= 1)
        {
            return;
        }

        // Split the array into 2.

        int middleIndex = items.Length / 2;

        int[] left = new int[middleIndex];
        int[] right = new int[items.Length - middleIndex];

        Array.Copy(items, 0, left, 0, middleIndex);
        Array.Copy(items, middleIndex, right, 0, items.Length - middleIndex);

        // Sort each array

        MergeSort(left);
        MergeSort(right);

        // Merge the sorted halves

        Merge(items, left, right);
    }

    private static void Merge(int[] result, int[] left, int[] right)
    {
        int resultIndex = 0;
        int leftIndex = 0;
        int rightIndex = 0;

        // Loop through the maximum length array number of times.

        while (resultIndex < result.Length)
        {
            if (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];

                    rightIndex++;
                }
            }
            else
            {
                // Assumes one of the left or right indexs are already merged
                
                if (leftIndex < left.Length)
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }

                if (rightIndex < right.Length)
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                }
            }

            resultIndex++;
        }
    }
}
