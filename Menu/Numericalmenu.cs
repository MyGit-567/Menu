using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class Numericalmenu : IPrint
    {
        Dictionary<int, Iaction> dict1;

        public void Print()
        {
            foreach(KeyValuePair<int,Iaction> dictionaryEntry in dict1)
            {
                Console.WriteLine(dictionaryEntry.Key);
                Console.WriteLine(dictionaryEntry.Value.Description());
            }

            dict1[Validate(Console.ReadLine())].Action();
        }
        public Numericalmenu(Dictionary<int, Iaction> dict1)
        {
            this.dict1 = dict1;
        }

        private int Validate(string input)
        {
            int number;
            
            while (!Int32.TryParse(input, out number) || !dict1.ContainsKey(number))
            {
                bool success = Int32.TryParse(input, out number);
                if (success)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", input, number);
                }
                else
                {
                    Console.WriteLine("Enter your input again: ");
                    input = Console.ReadLine();
                }
            }

            return number;
            
        }
    }
}
