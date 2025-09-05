namespace MergeSort.Tests;

public class MergeSortTests
{
    [Theory]
    [InlineData(new int[] { 7, 1, 9, 2, 5 }, new int[] { 1, 2, 5, 7, 9 })]
    [InlineData(new int[] { 42, 7, 19, 3, 88, 54, 23, 16, 71, 5, 30, 12, 91, 2, 67, 49, 81, 14, 60, 35 }, new int[] {2, 3, 5, 7, 12, 14, 16, 19, 23, 30, 35, 42, 49, 54, 60, 67, 71, 81, 88, 91})]
    public void ValidInput_SortedResult(int[] unsortedArray, int[] expectedResult)
    {
        LearningMergeSort.MergeSort(unsortedArray);

        Assert.Equal(expectedResult, unsortedArray);
    }
}
