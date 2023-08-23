namespace Algoritm.Utility
{
    public static class Sort
    {
        public enum SortOrder
        {
            Ascending,
            Descending
        }

        public static int[] BubbleSort(int[] arr, SortOrder sortOrder)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if ((sortOrder == SortOrder.Ascending && arr[i] > arr[j + 1]) ||
                        (sortOrder == SortOrder.Descending && arr[j] < arr[j + 1]))
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }

            return arr;
        }

        static void Swap(IList<int> arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
