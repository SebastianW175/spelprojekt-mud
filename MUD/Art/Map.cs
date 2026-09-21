using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Art
{
    internal class Map
    {
        public void ShowMapGraphic()
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("D = dungeon entrance     |           /¨¨¨\\              /¨¨¨\\");
            Console.WriteLine("M = main hall            |           | L |              | T |");
            Console.WriteLine("S = sewer system         |           \\___/              \\___/");
            Console.WriteLine("R = resting grounds      |             |                  |");
            Console.WriteLine("H = hidden camp          |   /¨¨¨\\   /¨¨¨\\      /¨¨¨\\   /¨¨¨\\   /¨¨¨\\");
            Console.WriteLine("A = abandoned storage    |   | A |---| H |------| R |---| M |---| S |");
            Console.WriteLine("L = leaning tower        |   \\___/   \\___/      \\___/   \\___/   \\___/");
            Console.WriteLine("T = treasure chamber     |                                |");
            Console.WriteLine("                         |                              /¨¨¨\\");
            Console.WriteLine("                         |                              | D |");
            Console.WriteLine("                         |                              \\___/");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
