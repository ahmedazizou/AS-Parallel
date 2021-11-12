using System;
using System.Threading;

namespace ParallelProgramming.Task1
{


    public class Program
    {
        // This function runs the bubble sort algorithm in 2 threads
        public static void ParallelCalcTwoThreads()
        {
            // declaring the array with value of 100,000 values.
            int[] array = new int[100000];
            // declaring threads out of the BubbleSort class and passing a high and low value parameter
            // for splitting the work among the threads
            // This contains two threads with the number values and the array declared above
            var t1 = new BubbleSort(0, 50000, array);
            var t2 = new BubbleSort(50000, 100000, array);
            t1.Start();
            t2.Start();
            // Checking if the threads are still running
            while (t1.IsAlive || t2.IsAlive)
            {
                Thread.Sleep(4);
            }
        }
        // This function runs the bubble sort algorithm in 3 threads
        public static void ParallelCalcThreeThreads()
        {
            // declaring the array with value of 100,000 values.
            int[] array = new int[100000];
            // declaring threads out of the BubbleSort class and passing a high and low value parameter
            // for splitting the work among the threads
            // This contains three threads with the number values and the array declared above
            var t1 = new BubbleSort(0, 30000, array);
            var t2 = new BubbleSort(30000, 60000, array);
            var t3 = new BubbleSort(60000, 100000, array);
            t1.Start();
            t2.Start();
            t3.Start();
            // Checking if the threads are still running
            while (t1.IsAlive || t2.IsAlive || t3.IsAlive)
            {
                Thread.Sleep(4);
            }
        }
        // This function runs the bubble sort algorithm in 4 threads
        public static void ParallelCalcFourThreads()
        {
            // declaring the array with value of 100,000 values.
            int[] array = new int[100000];
            // declaring threads out of the BubbleSort class and passing a high and low value parameter
            // for splitting the work among the threads
            // This contains four threads with the number values and the array declared above
            var t1 = new BubbleSort(0, 20000, array);
            var t2 = new BubbleSort(20000, 40000, array);
            var t3 = new BubbleSort(40000, 80000, array);
            var t4 = new BubbleSort(80000, 100000, array);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            // Checking if the threads are still running
            while (t1.IsAlive || t2.IsAlive || t3.IsAlive || t4.IsAlive)
            {
                Thread.Sleep(4);
            }
        }
        // This function runs the bubble sort algorithm in 6 threads
        public static void ParallelCalcSixThreads()
        {
            // declaring the array with value of 100,000 values.
            int[] array = new int[100000];
            // declaring threads out of the BubbleSort class and passing a high and low value parameter
            // for splitting the work among the threads
            // This contains four threads with the number values and the array declared above
            var t1 = new BubbleSort(0, 10000, array);
            var t2 = new BubbleSort(10000, 20000, array);
            var t3 = new BubbleSort(20000, 30000, array);
            var t4 = new BubbleSort(30000, 40000, array);
            var t5 = new BubbleSort(40000, 50000, array);
            var t6 = new BubbleSort(50000, 100000, array);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();

            // Checking if the threads are still running
            while (t1.IsAlive || t2.IsAlive || t3.IsAlive || t4.IsAlive || t5.IsAlive || t6.IsAlive)
            {
                Thread.Sleep(4);
            }
        }
        public static void Main(String[] args)
        {
            // Calculating Time for 2 Threads
            var tBefore2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ParallelCalcTwoThreads();
            var tAfter2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 2 Threads : " + (tAfter2 - tBefore2).ToString());
            // Calculating Time for 3 Threads
            var tBefore3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ParallelCalcThreeThreads();
            var tAfter3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 3 Threads: " + (tAfter3 - tBefore3).ToString());
            // Calculating Time for 4 Threads
            var tBefore4 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ParallelCalcFourThreads();
            var tAfter4 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 4 Threads: " + (tAfter4 - tBefore4).ToString());
            // Calculating Time for 6 Threads
            var tBefore6 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ParallelCalcSixThreads();
            var tAfter6 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 6 Threads: " + (tAfter6 - tBefore6).ToString());
        }
    }
}