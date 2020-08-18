using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Freemenu : IPrint
    {
        public void Print()
        {
            foreach (KeyValuePair<string, Iaction> dictionaryEntry in lala)
            {
                Console.WriteLine(secondDictionary.Key);
                Console.WriteLine(secondDictionary.Value.Description());
            }

            lala[Validate("1")].Action();
        }
        Dictionary<int, Iaction> lala;

        public Freemenu(Dictionary<string, Iaction> lala)
        {
            this.lala = lala;
        }

        private int Validate(string input)
        {
            return 1;
        }
    }
}
