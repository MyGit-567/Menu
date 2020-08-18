using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Numericalmenu : IPrint
    {
        public void Print()
        {
            foreach(KeyValuePair<int,Iaction> dictionaryEntry in bla)
            {
                Console.WriteLine(dictionaryEntry.Key);
                Console.WriteLine(dictionaryEntry.Value.Description());
            }

            bla[Validate("1")].Action();
        }
        Dictionary<int, Iaction> bla;

        public Numericalmenu(Dictionary<int, Iaction> bla)
        {
            this.bla = bla;
        }

        private int Validate(string input)
        {
            return 1;
        }
    }
}
