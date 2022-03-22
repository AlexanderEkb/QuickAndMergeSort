namespace Exercize
{
  class QuickSortOne : ISort
  {
    int[] _Array = new int[0];
    public void Sort(int[] Array)
    {
      _Array = Array;
      DoWork(0, _Array.Length-1);
      Array = _Array;
    }

    void DoWork(int a, int b)
    {
      int M = Split(a, b);
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
        if(_Array[L] <= Pivot)
        {
          if(L<b) L++;
        }
        else if(_Array[R] > Pivot)
        {
          if(R>a) R--;
        }
        else
        {
          Swap(L, R);
        }
      }

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