﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Becktomenu : Iaction
    {
        public void Action()
        {
            Console.WriteLine("good");
        }

        public string Description()
        {
            return "print good to the screen";
        }
    }
}
