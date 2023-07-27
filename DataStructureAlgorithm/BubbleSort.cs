using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BubbleSort
    {
        public void SortBubble()
        {
            Console.WriteLine("Enter the limit:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the integers:");
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int j = 0; j <= n - 2; j++)
            {
                for (int i = 0; i <= n - 2; i++)
                {
                    if (ar[i] > ar[i + 1])
                    {
                        temp = ar[i + 1];
                        ar[i + 1] = ar[i];
                        ar[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach(var item in ar)
                Console.WriteLine(item + " ");
        }
    }
}
