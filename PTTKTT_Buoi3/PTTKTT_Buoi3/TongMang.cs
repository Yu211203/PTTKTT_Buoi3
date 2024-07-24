using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    public class TongMang
    {
        public int SumDivideAndConquer(int left, int right)
        {
            int totalSum = 0;
            int mid = (left + right) / 2;
            for (int i = left; i <= mid; i++)
            {
                totalSum += i;
            }

            for (int i = mid + 1; i <= right; i++)
            {
                totalSum += i;
            }

            return totalSum;
        }

    }
}
