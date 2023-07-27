using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class InsertionSort
    {
        public void SortByInsertion(string[] ar)
        {
            int n = ar.Length;
            for (int i = 1; i < n; i++)
            {
                string temp = ar[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(ar[j], temp) > 0)
                {
                    ar[j + 1] = ar[j];
                    j = j - 1;
                }

                ar[j + 1] = temp;
            }
        }

        public void Display(string[] ar)
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
