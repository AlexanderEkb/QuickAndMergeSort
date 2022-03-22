namespace Exercize
{
  class QuickSortTwo : ISort
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
      int A = L -1;

      for(int i = L; i <= R; i++)
      {
        if(_Array[i] <= Pivot)
        {
          A++;
          Swap(A, i);
        }
      }
      return A;
    }

    void Swap(int a, int b)
    {
      int tmp = _Array[a];
      _Array[a] = _Array[b];
      _Array[b] = tmp;
    }
  }
}