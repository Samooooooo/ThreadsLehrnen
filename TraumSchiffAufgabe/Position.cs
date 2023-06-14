using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraumSchiffAufgabe
{
  internal class Position
  {
    public int x { get; set; }
    public int y { get; set; }

    Random random = new Random();
    public Position()
    {
      SetPosition();
    }

    public void SetPosition()
    {
      x = random.Next(0, Console.WindowWidth);
      y = random.Next(0, Console.WindowHeight);
    }
  }
}
