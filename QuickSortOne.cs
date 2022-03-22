namespace Exercize
{
  class QuickSortOne : ISort
  {
    int[] _Array = new int[0];
    public void Sort(int[] Array)
    {
      _Array = Array;
      DoWork(0, _Array.Length-1);
      // for(int i=0; i < _Array.Length; i++)
      // {
      //   Console.Write($"{_Array[i]} ");
      // }
      // Console.WriteLine("");
      Array = _Array;
    }

    void DoWork(int a, int b)
    {
      // Console.Write($"{a}:{b}->");
      int M = Split(a, b);
      // Console.WriteLine($"{M}");
      if(M>a)
      {
        DoWork(a, M-1);
      }
      if(M < b)
      {
        DoWork(M, b);
      }
    }
    int Split(int a, int b)
    {
      int Pivot = _Array[b];
      int L = a;
      int R = b;

      while(L<R)
      {
        // Console.Write($"{L}-{R}");

        if(_Array[L] <= Pivot)
        {
          if(L<b)
          {
            L++;
            // Console.WriteLine(@"L");
          }
        }
        else if(_Array[R] > Pivot)
        {
          if(R>a)
          {
            R--;
            // Console.WriteLine(@"R");
          }
        }
        else{
          Swap(L, R);
          // Console.WriteLine(@"S");
        }
      }
      // Console.WriteLine(@"---");

      return L;
    }

    void Swap(int a, int b)
    {
      int tmp = _Array[a];
      _Array[a] = _Array[b];
      _Array[b] = tmp;
    }
  }
}