using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableSearch
{
    class Program
    {
        static Hashtable userSearchHashTable;

        static void Main(string[] args)
        {
            userSearchHashTable = new Hashtable();

            Console.WriteLine("Type in a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Total Words: " + sentence.Split().Length);

            int i = 1;
            foreach (string word in sentence.Split())
            {
                if (userSearchHashTable.Contains(word))
                    userSearchHashTable[word] = i + 1;
                else
                {
                    userSearchHashTable.Add(word, i);
                }
            }

            foreach (DictionaryEntry entry in userSearchHashTable)
            {
                Console.WriteLine("Word: " + entry.Key + " Appearance: " + entry.Value);
            }

            //string matchOne = "My computer wont turn on";
            //string matchTwo = "Chromebook screen is black";
            //string matchThree = "Lexia keeps asking for cookies";

            //foreach(DictionaryEntry word in userSearchHashTable)
            //{
            //    if ()
            //}
        }
    }
}
