using System;
using System.Collections.Generic;

namespace ParallelProgramming.Task2
{
    public class BarcodeList
    {
        // declaring the attributes
        private readonly List<Type> _items;
        public int[] Barcode1;
        public int[] Barcode7;
        public int[] Barcode10;

        // BarcodeList constructor with item parameter
        public BarcodeList(List<Type> items)
        {
            _items = items;
            Barcode1 = new int[3];
            Barcode7 = new int[5];
            Barcode10 = new int[8];
        }

        public void GetTypes()
        {
            // This function iterates through the items, and selects values for of 3,5 and 8.
            var i = _items.GetEnumerator();
            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            while (i.MoveNext())
            {
                var item = i.Current;
                if (item.BarcodeType == 1 && counter1 < 3)
                {
                    Barcode1[counter1] = item.Barcode;
                    counter1++;
                }
                else if (item.BarcodeType == 7 && counter2 < 5)
                {
                    Barcode7[counter2] = item.Barcode;
                    counter2++;
                }
                else if (item.BarcodeType == 10 && counter3 < 8)
                {
                    Barcode10[counter3] = item.Barcode;
                    counter3++;
                }
                if ((counter3 > 8 && counter1 > 3 && counter2 < 5))
                {
                    break;
                }
            }
        }

        // This function prints the types of barcodes generated
        public void PrintTypes()
        {
            Console.WriteLine("Barcodes of Type 1 : ");
            DisplayResults(Barcode1);
            Console.WriteLine("Barcodes of Type 7 : ");
            DisplayResults(Barcode7);
            Console.WriteLine("Barcodes of Type 10 : ");
            DisplayResults(Barcode10);
        }
        // This function displays the results of the selection
        private static void DisplayResults(int[] a)
        {
            for (var count = 0; count < a.Length; count++)
            {
                Console.WriteLine($"The Barcode of the {count + 1} item = {a[count]}");
            }
        }
    }
}
