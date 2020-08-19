using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Exit : Iaction
    {

        public void Action()
        {
            Console.WriteLine("Exit");
        }

        public string Description()
        {
            return "GoodBye";
        }
    }
}
