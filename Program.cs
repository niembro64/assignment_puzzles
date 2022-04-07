using System;
using System.Collections.Generic;

namespace assignment_puzzles
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] a;
      a = RandomArray();
      h.p(a);

      ////////////////

      h.p("\n");
      h.p("\n");
      h.p(GetMax(a));
      h.p("\n");
      h.p(GetMin(a));
      h.p("\n");
      h.p(GetSum(a));
      h.p("\n");
      h.p("\n");
      h.p($"Coin Toss Result : {TossCoin()}");
      h.p("\n");
      h.p($"Heads Ratio : {TossCoinMultiple(5)}");
      h.p("\n");
      h.p($"Heads Ratio : {TossCoinMultiple(9)}");
      h.p("\n");
      h.p($"Heads Ratio : {TossCoinMultiple(55)}");
      h.p("\n");
      h.p("\n");
      h.p("printing new list:");
      h.p(Names());
      h.p("\n");
      h.p("\n");
      h.p(RemoveBig(Names()));

    }
    public static Random rand = new Random();
    public const int MinValue = -2147483648;
    public const int MaxValue = 2147483647;

    public static List<string> Names()
    {
      List<string> n = new List<string>();
      List<string> n2 = new List<string>();

      n.Add("Todd");
      n.Add("Tiffany");
      n.Add("Charlie");
      n.Add("Geneva");
      n.Add("Sydney");

      int r;
      int nc = n.Count;
      for (int i = 0; i < nc; i++)
      {
        h.p($"i : {i} | n.Count: {n.Count} \n");
        r = rand.Next(0, n.Count);
        n2.Add(n[r]);
        n.RemoveAt(r);
      }
      h.p("\n");

      return n2;
    }

    public static List<string> RemoveBig(List<string> a)
    {
      List<string> b = new List<string>();

      for (int i = 0; i < a.Count; i++)
      {
        if (a[i].Length <= 5)
        {
          b.Add(a[i]);
        }
      }
      return b;
    }

    public static double TossCoinMultiple(int numTimes)
    {
      string[] coinArr = new string[numTimes];
      int numHeads = 0;

      double result;

      for (int i = 0; i < numTimes; i++)
      {
        coinArr[i] = TossCoin();
        if (coinArr[i] == "Heads")
        {
          numHeads++;
        }

      }
      result = (double)numHeads / (double)numTimes;
      return result;
    }

    public static string TossCoin()
    {
      //   h.p("Tossing a Coin!");
      string result = "";
      result = rand.Next(0, 2) % 2 == 1 ? "Heads" : "Tails";
      //   h.p(result);
      return result;
    }

    public static int[] RandomArray()
    {
      int[] a = new int[10];

      for (int i = 0; i < 10; i++)
      {
        a[i] = rand.Next(5, 25);
      }


      return a;
    }

    public static int GetMax(int[] a)
    {
      int max = MinValue;
      for (int i = 0; i < a.Length; i++)
      {
        if (a[i] > max)
        {
          max = a[i];
        }
      }
      return max;
    }
    public static int GetMin(int[] a)
    {
      int min = MaxValue;
      for (int i = 0; i < a.Length; i++)
      {
        if (a[i] < min)
        {
          min = a[i];
        }
      }
      return min;
    }
    public static int GetSum(int[] a)
    {
      int sum = 0;
      for (int i = 0; i < a.Length; i++)
      {
        sum += a[i];
      }
      return sum;
    }
  }
}
