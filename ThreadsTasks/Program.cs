using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsTasks
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Task task1 = new Task(() => { Method1("Task-1"); });
      task1.Start();

      Task task2 = Task.Run(() => { Method1("Task-2"); }); // Automatic Start

      Task task3 = Task.Factory.StartNew(() => { Method1("Task-3"); });

      Console.WriteLine("Main-Methode");
      //task1.Wait();
      //task2.Wait();
      //task3.Wait();
      //OR
      Task.WaitAll(task1, task2, task3);

    }
    static void Method1(string taskName)
    {
      Task.Delay(50);
      Console.WriteLine(taskName);
    }
  }
}
