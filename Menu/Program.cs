using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Iaction addaption = new Addoption();
            Iaction becktomenu = new Becktomenu();

            var actionDictionary = new Dictionary<int, Iaction>
            {
                {1 , addaption },
                {2, becktomenu }
            };


            var secondDictionary = new Dictionary<string, Iaction>
            {
                {"2",  becktomenu },
                {"first", addaption }
            };

            var numericMenu = new Numericalmenu(actionDictionary);

            var freemenu = new Freemenu(secondDictionary);
            numericMenu.Print();
            freemenu.Print();
        }
    }
}
