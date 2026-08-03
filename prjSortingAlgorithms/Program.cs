namespace prjSortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bubble sort

            // Unsorted Array
            int[] array = { 64, 34, 25, 12, 11, 22, 90 };

            Console.WriteLine("Unsorted Array");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("\n Sorted Array");
            PrintArray(array);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            // Outer loop for the number of passes
            for (int i = 0; i < n -1; n++)
            {
                swapped = false;

                // Inner loop to compare the adjacent elements
                for (int j = 0; j < n -1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no swaps occured, the area is already sorted
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
