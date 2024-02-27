namespace BinarySearch;

public class BinarySearchTests
{
    [Test]
    public void ArrayContainsNumber()
    {
        // Arrange
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int expectedIndex = 2;
        int expectedNumber = 3;
        int low = 0;
        int high = 9;

        // Act
        (int, int) result = BinarySearch.Search(sortedArray, expectedNumber, low, high);

        // Assert
        Assert.That((expectedIndex, expectedNumber), Is.EqualTo(result),
         $"Expected index {expectedIndex} for target {expectedNumber}.");

    }

    [Test]
    public void ArrayNumberMissing()
    {

        // Arrange
        int[] sortedArray = { 1, 2, 3, 4, 5 };
        int expectedIndex = -1;
        int expectedNumber = -1;
        int outOfBoundsNum = 0;
        int low = 0;
        int high = 4;

        // Act
        (int, int) result = BinarySearch.Search(sortedArray, outOfBoundsNum, low, high);

        // Assert
        Assert.That((expectedIndex, expectedNumber), Is.EqualTo(result),
         $"Expected ({expectedIndex},{expectedNumber}) the target is not in the array.");
    }
}