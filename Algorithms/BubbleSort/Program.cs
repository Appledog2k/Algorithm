using Algorithms.BubbleSort;
public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 2, 4, 1, 6, 7, 10, 8 };
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.sort(arr);
        Console.WriteLine("Bubble Sort");
        bubbleSort.printArray(arr);

    }
}