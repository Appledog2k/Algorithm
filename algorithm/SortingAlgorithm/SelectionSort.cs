namespace SelectionSort
{
    // độ phức tạp 0(N^2)
    // thuật toán luôn duy trì 2 mảng con, một mảng đã được sắp xếp, một mảng chwua được sắp xếp
    class SelectionSort
    {
        static void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                        //* swap 
                        int temp = arr[min_idx];
                        arr[min_idx] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}