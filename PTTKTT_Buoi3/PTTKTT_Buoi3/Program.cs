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
        Console.WriteLine("=======Tong Mang ( Khong de qui va Co de qui=========");
        Console.WriteLine("***Khong de qui");
        Console.Write("Nhap n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = sumArray.SumDivideAndConquer(1, n);
        Console.WriteLine("Tong cac phan tu tu 1 den n la: "+sum);
        Console.WriteLine("\n***Co de qui");
        Dequi dequi = new Dequi();
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum2 = dequi.SumDivideAndConquerRecursion(A, 0, A.Length - 1);
        Console.Write("\n Tong cac phan tu mang: " + sum2);
        Console.WriteLine("\n*********************************************************");
        Console.WriteLine("\n========QuickSort========");
        QuickSort quicksort = new QuickSort();
        int[] arr = { 12, 4, 7, 3, 1, 9 };

        Console.WriteLine("\nMang ban dau:");
        quicksort.Print(arr);
            
        quicksort.Quicksort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nMang sau khi sap xep:");
        quicksort.Print(arr);
        Console.WriteLine("\n*********************************************************");
        Console.WriteLine("=======BinarySearch========");
        Console.WriteLine("\n****NonRecursion");
        BinarySearchnonRecursion nonRecursion = new BinarySearchnonRecursion();
        int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Mang ban dau: ");
        nonRecursion.Print(Arr);
        Console.WriteLine("Nhap so ban muon tim kiem: ");
        int target = int.Parse(Console.ReadLine());
       
        int kq = nonRecursion.BinarySearch_nonRecursion(Arr, target);
        if(kq != -1 )
        {
            Console.WriteLine("Vi tri la: "+kq);
        }else
        {
            Console.WriteLine("KHONG TIM THAY");
        }

        Console.WriteLine("\n***Recursion");
        BSRecursion recursion = new BSRecursion();
        int[] M = { 0, 12, 3, 25, 56, 6 };
        Array.Sort(M);
        Console.WriteLine("\nMang ban dau: ");
        recursion.Print(M);
        Console.WriteLine("Nhap so can tim: ");
        int Target = int.Parse(Console.ReadLine());
        int Kq = recursion.BinarySearch_Recursion(M, Target);
        if (Kq != -1)
        {
            Console.WriteLine("\nVi tri : " + Kq);
        }
        else
        {
            Console.WriteLine("KHONG TIM THAY");
        }

        Console.ReadLine();
        }
    }
}
