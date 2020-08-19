using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class Freemenu : IPrint
    {
        public void Print()
        {
            foreach (KeyValuePair<string, Iaction> secondDictionary in dict2)
            {
                Console.WriteLine(secondDictionary.Key);
                Console.WriteLine(secondDictionary.Value.Description());
            }

            dict2[Validate("first")].Action();
        }

        Dictionary<string, Iaction> dict2;

        public Freemenu(Dictionary<string, Iaction> lala)
        {
            this.dict2 = lala;
        }

        private string Validate(string input)
        {
            if(dict2.ContainsKey(input))
                return input;
            else
            {
                return Validate(Console.ReadLine());
            }
        }
    }
}
