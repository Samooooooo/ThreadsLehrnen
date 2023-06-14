using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Tasks_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Main started");
      Task<int> task1 = Task.Run(() => Add2Num(21, 21));

      Console.WriteLine(task1.Result);
      Console.WriteLine("Main finished");

      Task<int> task2 = Task.Run(() => Add2Num(21, 21));
      Task<int> task3 = task2.ContinueWith(v => Add2Num(v.Result, v.Result));
      Console.WriteLine(task3.Result);

      Task.Factory.StartNew(() => 1)
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Add2Num(v.Result, v.Result))
        .ContinueWith(v => Console.WriteLine(v.Result))
        .Wait();
    }
    static int Add2Num(int num1, int num2)
    {
      Console.WriteLine("Add started");
      Task.Delay(500);
      Console.WriteLine("Add finished");
      return num1 + num2;
    }
  }
}
