using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class BSRecursion
    {
        public int BinarySearch_Recursion(int[] array, int target)
        {
            return BinarySearch_Recursion(array, target, 0, array.Length - 1);
        }
        private int BinarySearch_Recursion(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1; 
            }

            
            int mid = left + (right - left) / 2;

            
            if (array[mid] == target)
            {
                return mid;
            }

            
            if (array[mid] < target)
            {
                return BinarySearch_Recursion(array, target, mid + 1, right);
            }
           
            else
            {
                return BinarySearch_Recursion(array, target, left, mid - 1);
            }
        }
        public void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
