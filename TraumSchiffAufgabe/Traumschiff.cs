using System;
using System.Threading;

namespace TraumSchiffAufgabe
{
  internal class Traumschiff
  {
    public string Name { get; set; }
    public Position Position { get; set; }
    private static object LockObj = new object();
    private ConsoleColor color;

    public Traumschiff(string name, ConsoleColor color)
    {
      this.Name = name;
      this.color = color;
      Position = new Position();
      ShowShip();
    }
    public Traumschiff(string name)
    {
      this.Name = name;
      Position = new Position();
      ShowShip();
    }
    public void ShowShip()
    {
      lock (LockObj)
      {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(Name);
      }
    }
    public void RemoveShip()
    {
      lock (LockObj)
      {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(new string('~', Name.Length));
      }
    }

    public void LeadTheShip()
    {
      for (int i = 0; i < 30; i++)
      {
        RemoveShip();
        Position NPosition = new Position();

        while (NPosition.x != Position.x || NPosition.y != Position.y)
        {
          RemoveShip();
          if (NPosition.x > Position.x)
          {
            Position.x++;
          }
          else if (NPosition.x < Position.x)
          {
            Position.x--;
          }

          if (NPosition.y > Position.y)
          {
            Position.y++;
          }
          else if (NPosition.y < Position.y)
          {
            Position.y--;
          }
          ShowShip();
          Thread.Sleep(10);
        }
      }
    }

  }
}
