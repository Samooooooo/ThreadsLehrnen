using System;
using System.Threading;

namespace TraumSchiffAufgabe
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.CursorVisible = false;
      Traumschiff traumschiff1 = new Traumschiff("q_|_p", ConsoleColor.Green);
      Traumschiff traumschiff2 = new Traumschiff("q_|_p", ConsoleColor.Red);
      Traumschiff traumschiff3 = new Traumschiff("q_|_p", ConsoleColor.Blue);
      Traumschiff traumschiff4 = new Traumschiff("q_|_p", ConsoleColor.DarkYellow);

      Thread thread1 = new Thread(traumschiff1.LeadTheShip);
      Thread thread2 = new Thread(traumschiff2.LeadTheShip);
      Thread thread3 = new Thread(traumschiff3.LeadTheShip);
      Thread thread4 = new Thread(traumschiff4.LeadTheShip);

      thread1.Start();
      thread2.Start();
      thread3.Start();
      thread4.Start();

      //thread1.Join();
      //thread1.Join();
      //thread2.Join();
      //thread3.Join();
      //thread4.Join();
    }
  }
}
