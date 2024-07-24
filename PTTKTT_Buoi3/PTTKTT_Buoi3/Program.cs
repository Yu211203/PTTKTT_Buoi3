using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        TongMang sumArray = new TongMang();
        Console.Write("Nhap n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = sumArray.SumDivideAndConquer(1, n);
        Console.WriteLine("Tong cac phan tu tu 1 den n la ( Khong de qui) : "+sum);

        Dequi dequi = new Dequi();
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum2 = dequi.SumDivideAndConquerRecursive(A, 0, A.Length - 1);
        Console.Write("\n Tong cac phan tu mang(De qui): " + sum2);
        
        Console.ReadLine();
        }
    }
}
