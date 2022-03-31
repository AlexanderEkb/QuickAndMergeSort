namespace Exercize
{
  class MergeSort : ISort
  {
    int[] Array = new int[0];
    public void Sort(int[] Arr)
    {
      Array = Arr;
      DoWork(0, Array.Length-1);
      Arr = Array;
    }

    void DoWork(int L, int R)
    {
      if(L < R)
      {
        int X = (L + R) / 2;
        DoWork(L, X);
        DoWork(X + 1, R);
        Merge(L, X, R);
      }
    }
    void Merge(int L, int X, int R)
    {
      int Length = R - L + 1;

      int[] Temp = new int[Length];
      int P1 = L;
      int P2 = X + 1;
      int Dest = 0;
      int Smaller = -1;

      while(true)
      {
        if((P2 > R) || ((P1 <= X) && (Array[P1] <= Array[P2])))
        {
          Smaller = P1;
          P1++;
        }
        else /* if((Array[P2] <= Array[P1]) || (P1 > X)) */
        {
          Smaller = P2;
          P2++;
        }
        Temp[Dest] = Array[Smaller];
        Dest++;

        if((P1 > X) && (P2 > R))
        {
          break;
        }
      }

      for(int i=0; i<Length; i++)
      {
        Array[i+L] = Temp[i];
      }
    }
  }
}