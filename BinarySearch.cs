namespace BinarySearch;

class BinarySearch
{

    // Binary search that returns the index and number
    public static (int, int) Search(int[] sortedArray, int target, int low, int high)
    {


        if (low <= high)
        {
            int mid = (low + high) / 2;

            if (sortedArray[mid] == target)
            {
                return (mid, sortedArray[mid]);
            }
            else if (sortedArray[mid] > target)
            {
                return Search(sortedArray, target, low, mid - 1);
            }
            else
            {
                return Search(sortedArray, target, mid + 1, high);
            }
        }


        return (-1, -1);
    }
}