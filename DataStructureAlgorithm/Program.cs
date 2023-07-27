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
                    "3.Replace String\n 4.Exit");
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
                        flag = false;
                        break;
                }
            }
        }

    }
}