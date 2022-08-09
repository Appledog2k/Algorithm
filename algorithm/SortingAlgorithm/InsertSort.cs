namespace InsertionSort
{
    public class InsertionSort
    {
        public void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j < n && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                key = arr[j + 1];
            }
        }
    }
}