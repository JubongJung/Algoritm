namespace Algoritm.Utility
{
    public static class Sort
    {
        public enum SortOrder
        {
            Ascending,
            Descending
        }

        /// <summary>
        /// 서로 인접한 두 원소를 검사하여 정렬하는 알고리즘
        /// 버블 정렬은 첫 번째 자료와 두 번째 자료를, 두 번째 자료와 세 번째 자료를, 세 번째와 네 번째를, … 이런 식으로 (마지막-1)번째 자료와 마지막 자료를 비교하여 교환하면서 자료를 정렬한다.
        /// </summary>
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

        private static void Swap(IList<int> arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void QuickSort(int[] arr, int left, int right, SortOrder sortOrder)
        {
            int pivot = (left + right) / 2;

            int tmpLeft = left;
            int tmpRight = right;

            while (tmpLeft < tmpRight)
            {
                while (arr[tmpLeft] < arr[pivot])
                {
                    tmpLeft++;
                }

                while (arr[tmpRight] > arr[pivot])
                {
                    tmpRight--;
                }

                Swap(arr, tmpLeft, tmpRight);
                //tmpLeft++;
                //tmpRight--;

                Console.WriteLine($"pivot: {pivot}, left: {tmpLeft}, right: {tmpRight}");
                Console.WriteLine($"pivot-value: {arr[pivot]}, left-value: {arr[tmpLeft]}, right-value: {arr[tmpRight]}");
                Console.WriteLine(String.Join(',', arr));
            }
            Console.WriteLine($"Result======================");
            Console.WriteLine($"[{left},{right},{pivot}], {String.Join(',', arr)}");



            int leftSideLeft = left;
            int leftSideRight = pivot - 1;
            int rightSideLeft = pivot;
            int rightSideRight = right;
            Console.WriteLine($"{leftSideLeft} ~ {leftSideRight} / {rightSideLeft} ~ {rightSideRight}");

            int leftSideLength = leftSideRight - leftSideLeft;
            int rightSideLength = rightSideRight - rightSideLeft;

            if (leftSideLength > 1)
            {
                QuickSort(arr, leftSideLeft, leftSideRight, sortOrder);
            }
            if (leftSideLength == 1 && arr[leftSideLeft] > arr[leftSideRight])
            {
                Swap(arr, leftSideLength, leftSideRight);
            }

            if (rightSideLength > 1)
            {
                QuickSort(arr, rightSideLeft, rightSideRight, sortOrder);
            }
            if (rightSideLength == 1 && arr[rightSideLeft] > arr[rightSideRight])
            {
                Swap(arr, rightSideLeft, rightSideRight);
            }

            Console.WriteLine($"[{String.Join(',', arr)}]");
        }
    }
}