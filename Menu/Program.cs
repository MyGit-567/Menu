using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Iaction addaption = new Addoption();
            var actionDictionary = new Dictionary<int, Iaction>
            {
                {1 , addaption }
            };

            var numericMenu = new Numericalmenu(actionDictionary);

            Iaction becktomenu = new Becktomenu();
            var secondDictionary = new Dictionary<string, Iaction>
            {
                {"second" ,  becktomenu }
            };

            var freemenu = new Freemenu(secondDictionary);
            Console.WriteLine("Hello World!");
        }
    }
}
