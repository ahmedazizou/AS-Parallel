using System;
using System.Collections.Generic;
using System.Threading;

namespace ParallelProgramming.Task2
{
    public class Program
    {
        // This function selects barcodes with 2 threads
        public static void TwoThreads()
        {

            List<Type> barcode = new();
            GenerateItems(barcode);

            // BarcodeList class is initialized and barcode list is passed to it.
            // Two threads are declared and passed to the item

            BarcodeList item = new(barcode);
            Thread thread1 = new(item.GetTypes);
            Thread thread2 = new(item.GetTypes);

            thread1.Start();
            thread2.Start();

            // Checking if the threads are still running

            while (thread1.IsAlive|| thread2.IsAlive)
            {
                Thread.Sleep(4);
            }

            Console.WriteLine("Barcodes of 2 Threads are : ");
            item.PrintTypes();

        }



        // This function selects barcodes with 3 threads

        public static void ThreeThreads()
        {
            List<Type> barcode = new();
            GenerateItems(barcode);


            // BarcodeList class is initialized and barcode list is passed to it.
            // Three threads are declared and passed to the item

            BarcodeList item = new(barcode);
            Thread thread1 = new(item.GetTypes);
            Thread thread2 = new(item.GetTypes);
            Thread thread3 = new(item.GetTypes);

            // starting threads
            thread1.Start();
            thread2.Start();
            thread3.Start();


            // Checking if the threads are still active
            while (thread1.IsAlive || thread2.IsAlive || thread3.IsAlive)
            {
                Thread.Sleep(4);
            }

            Console.WriteLine("\n\nBarcodes of 3 Threads are : ");
            item.PrintTypes();

        }

        // This function selects barcodes with 4 threads

        public static void FourThreads()
        {

            List<Type> barcode = new();
            GenerateItems(barcode);


            // BarcodeList class is initialized and barcode list is passed to it.
            // Four threads are declared and passed to the item

            BarcodeList item = new(barcode);
            Thread thread1 = new(item.GetTypes);
            Thread thread2 = new(item.GetTypes);
            Thread thread3 = new(item.GetTypes);
            Thread thread4 = new(item.GetTypes);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            // Checking if the threads are still running
            while (thread1.IsAlive || thread2.IsAlive || thread3.IsAlive || thread4.IsAlive)
            {
                Thread.Sleep(4);
                
            }

            Console.WriteLine("\n\nBarcodes of 4 Threads are : ");
            item.PrintTypes();

        }


        // This function selects barcodes with 6 threads

        public static void SixThreads()
        {
            List<Type> barcode = new();
            GenerateItems(barcode);


            // BarcodeList class is initialized and barcode list is passed to it.
            // Six threads are declared and passed to the item

            BarcodeList item = new(barcode);
            Thread t1 = new(item.GetTypes);
            Thread t2 = new(item.GetTypes);
            Thread t3 = new(item.GetTypes);
            Thread t4 = new(item.GetTypes);
            Thread t5 = new(item.GetTypes);
            Thread t6 = new(item.GetTypes);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();

            // Checking if the threads are still active

            while (t1.IsAlive || t2.IsAlive || t3.IsAlive || t4.IsAlive || t5.IsAlive || t6.IsAlive)
            {
                Thread.Sleep(4);
            }


            Console.WriteLine("\n\nBarcodes of 6 Threads are : ");
            item.PrintTypes();

        }


        public static void Main(String[] args)

        {

            // This block of code compares the time taken for 2, 3, 4 and 6 Threads respectively

            // 2 thread time execution
            long tBefore2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            TwoThreads();
            long tAfter2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 2 Threads : " + (tAfter2 - tBefore2) + " Milliseconds");

            // 3 thread time execution
            long tBefore3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ThreeThreads();
            long tAfter3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 3 Threads : " + (tAfter3 - tBefore3) + " Milliseconds");

            // 4 thread time execution
            long tBefore4 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            FourThreads();
            long tAfter4 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 4 Threads : " + (tAfter4 - tBefore4) + " Milliseconds");

            // 6 thread time execution
            long tBefore5 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            SixThreads();
            long tAfter5 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine("Duration For 6 Threads : " + (tAfter5 - tBefore5) + " Milliseconds");

        }


        // This function generates Items of the class "Type"
        public static void GenerateItems(List<Type> items)
        {
            int counter = 100000;
            Random rand = new();
            while (counter >= 1)
            {
                Type item = new();
                int barcode = rand.Next(100000);
                item.Barcode = barcode;
                int number = rand.Next(100) + 1;
                item.BarcodeType = number;
                items.Add(item);
                counter--;
            }
        }
    }
}
