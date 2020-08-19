using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class Mvothermenu : Iaction
    {
        public void Action()
        {
            Console.WriteLine("Other menu");
        }

        public string Description()
        {
            return "print other menu to the screen";
        }
    }
}
