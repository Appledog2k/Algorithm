// See https://aka.ms/new-console-template for more information
using Algorithms.SelectionSort;

internal class Program
{
    public static void Main(string[] args)
    {
        SelectionSort selectionSort = new SelectionSort();
        Console.WriteLine("Selection Sort");
        int[] arr = { 3, 2, 4, 1, 6, 7, 10, 8 };
        selectionSort.sort(arr);
        selectionSort.printArray(arr);
    }
}