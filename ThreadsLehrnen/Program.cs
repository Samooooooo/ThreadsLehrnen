using System;
using System.Threading;

namespace ThreadsLehrnen
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Thread t1 = new Thread(Methode1);
      Thread t2 = new Thread(Methode1);
      Thread t3 = new Thread(Methode1);

      t1.Name = "Thread 1";
      t2.Name = "Thread 2";
      t3.Name = "Thread 3";

      //Threads Starten
      t1.Start(".");
      t2.Start("#");
      t3.Start("|");

      Thread.CurrentThread.Name = "Main";
      Methode1(" ");

      //Methode mit mehrere Parametern
      Thread t4 = new Thread(() => { Methode2("Ein kleiner Text", 10); });
      t4.Start();
    }
    static void Methode1(object obj)
    {
      Console.Write($"{Thread.CurrentThread.Name}/{Thread.CurrentThread.ManagedThreadId}");
      for (int i = 0; i < 1000; i++)
      {
        Console.Write((string)obj);

      }
    }
    static void Methode2(string text, int position)
    {
      Console.Write(text.Substring(position));
    }
  }
}
