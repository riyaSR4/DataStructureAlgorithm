using System;

namespace DataStructureAlgorithm
{
    class Program
    {
        static string searchFilePath = @"D:\BridgeLabs Training\DataStructureAlgorithm\DataStructureAlgorithm\Search.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to execute\n 1.Binary Search\n 2.Check Anagram or not\n " +
                    "3.Replace String\n 4.Insertion Sort\n 5.Bubble Sort\n 6.Print Prime Numbers between 0 and 1000\n " +
                    "7.Print Prime Numbers that are Anagram and Palindrome\n 8.Merge Sort\n 9.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadTextFileAndSearch(searchFilePath);
                        break;
                    case 2:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 3:
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.StringReplace();
                        break;
                    case 4:
                        InsertionSort insertionsort = new InsertionSort();
                        Console.WriteLine("Enter the limit:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the strings:");
                        string[] ar = new string[n];
                        for (int i = 0; i < n; i++)
                        {
                            ar[i] = Console.ReadLine();
                        }
                        insertionsort.SortByInsertion(ar);
                        Console.WriteLine("Sorted Array:");
                        insertionsort.Display(ar);
                        break;
                    case 5:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.SortBubble();
                        break;
                    case 6:
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        primeNumbers.PrintPrimeNumbers();
                        break;
                    case 7:
                        PrimeAnagramPalindrome primeAnagramPalindrome = new PrimeAnagramPalindrome();
                        primeAnagramPalindrome.CheckPrimeAnagramPalindrome();
                        break;
                    case 8:
                        MergeSort mergeSort = new MergeSort();
                        Console.WriteLine("Enter the limit:");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the strings:");
                        string[] ar1 = new string[n1];
                        for (int i = 0; i < n1; i++)
                        {
                            ar1[i] = Console.ReadLine();
                        }
                        mergeSort.SortByMerge(ar1);
                        Console.WriteLine("\nSorted Array:");
                        mergeSort.PrintArray(ar1);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }

    }
}