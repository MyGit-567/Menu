using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Addoption : Iaction
    {
        public void Action()
        {
            Console.WriteLine("2");
        }

        public string Description()
        {
            return "print 2 to the screen";
        }
    }
}
