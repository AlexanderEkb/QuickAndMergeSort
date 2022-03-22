using System.Diagnostics;

namespace Exercize
{
    class Program
    {
      const UInt32 Sizes = 8;
      static void Main(string[] args)
      {
        int ItemCount = 1;
        for(int i=0; i<Sizes; i++)
        {
          Stopwatch sw = new Stopwatch();
          int[] Array = PrepareArray(ItemCount);
          sw.Start();
          QuickSortOne QuickSorterOne = new QuickSortOne();
          // QuickSortTwo QuickSorterTwo = new QuickSortTwo();
          // MergeSort MergeSorter = new MergeSort();
          QuickSorterOne.Sort(Array);
          // QuickSorterTwo.Sort(Array);
          // QuickSorterOne.Sort(Array);
          sw.Stop();
          if(IsSorted(Array))
          {
            string Elapsed = sw.ElapsedMilliseconds.ToString();
            Console.WriteLine($"ItemCount={ItemCount}, {Elapsed} ms elapsed.");
          }
          else
          {
            Console.WriteLine($"Task failed for ItemCount={ItemCount}");
          }
          ItemCount *= 10;
        }
        // tester.RunTest(6);
      }
      static int[] PrepareArray(int Size)
      {
        int[] Array = new int[Size];
        Random rnd = new Random();
        for(int j=0; j<Size; j++)
        {
          Array[j] = rnd.Next(Size);
        }
        return Array;
      }
      static bool IsSorted(int[] Array)
      {
        bool Result = true;
        int From = 0;
        int To = Array.Length - 1;

        for(int i=From; i<To; i++)
        {
          if(Array[i] > Array[i+1])
          {
            Result = false;
            break;
          }
        }
        return Result;
      }
    }
}