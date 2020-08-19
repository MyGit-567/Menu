using Menu;
using System;
using System.Collections.Generic;

namespace MenuBuilder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Iaction addoption1 = new Addoption();
            Iaction becktomenu2 = new Becktomenu();
            var thirdDictionary = new Dictionary<int, Iaction>
            {
                {3 , addoption1 },
                {4, becktomenu2 }
            };

            var moreDictionary = new Dictionary<string, Iaction>
            {
                {"five", becktomenu2 },
                {"six", addoption1 }

            };

            var numericMenu1 = new Numericalmenu(thirdDictionary);
            var freemenunu1 = new Freemenu(moreDictionary);
            numericMenu1.Print();
            freemenunu1.Print();

        }

    }
}



        