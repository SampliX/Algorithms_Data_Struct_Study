using System;
using System.Diagnostics;
using static System.GC;
using Algorithms_Data_Struct_Study.Algorithm_classes;

namespace Algorithms_Data_Struct_Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestSearchMethods();
        }
        static void TestSearchMethods()
        {
            
            Stopwatch stopwatch = new Stopwatch();
            Random rnd = new Random();
            int[] a = new int[100000000];
            int x = rnd.Next() % 100000000;
            int result = -1;

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next() % 100000000;
            }

            GC.Collect();
            stopwatch.Start();
            result = SearchMethodsClass.SearchSimpleUnSort(a, x);
            stopwatch.Stop();
            Console.WriteLine($"SearchSimple elapsed: {stopwatch.ElapsedTicks}");
            Console.WriteLine($"Result: {result}");
            stopwatch.Reset();

            GC.Collect();
            stopwatch.Start();
            result = SearchMethodsClass.SearchBarrierUnSort(a, x);
            stopwatch.Stop();
            Console.WriteLine($"SearchBarrier elapsed: {stopwatch.ElapsedTicks}");
            Console.WriteLine($"Result: {result}");
            stopwatch.Reset();

            GC.Collect();
            stopwatch.Start();
            result = SearchMethodsClass.SearchSimpleMyUnSort(a, x);
            stopwatch.Stop();
            Console.WriteLine($"SearchSimpleMy elapsed: {stopwatch.ElapsedTicks}");

            Console.WriteLine($"Result: {result}");
        }
    }
}