using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class Dequi
    {
         public int SumDivideAndConquerRecursive(int[] arr,int left, int right)
        {
            int mid = (left + right) / 2;

            if (left == right)
            {
                return left;
            }

            int totalSumLeft = SumDivideAndConquerRecursive(arr, left, mid);
            int totalSumRight = SumDivideAndConquerRecursive(arr, mid + 1, right);
            return totalSumLeft + totalSumRight;
        }
    }
}
