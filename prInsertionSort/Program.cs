namespace prInsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unsorted Array
            int[] numbers = { 12, 11, 13, 5, 6 };

            Console.WriteLine("Original array:");
            PrintArray(numbers);

            InsertionSort(numbers);

            Console.WriteLine("\nSorted Array: \n");
            PrintArray(numbers);
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            // Start at teh second element
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i]; // The elemt we are currently trying to place
                int j = i - 1;

                // Move elements that are greater than the key to one position ahead of theirs
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; // Shift the larger element to the right
                    j = j - 1; // Move the next elemnt to the left
                }

                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int val in arr)
            {
                Console.WriteLine(val + " ");
            }

            Console.WriteLine();
        }
    }
}
