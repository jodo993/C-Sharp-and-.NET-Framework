using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace HashTableSearch
{
    class Program
    {
        //static Hashtable userSearchHashTable;
        //static Stopwatch sw;

        static void Main(string[] args)
        {
            //// Create hashtable
            //userSearchHashTable = new Hashtable();
            //sw = new Stopwatch();

            //// Create timer
            //float startTime = 0;
            //float endTime = 0;
            //float elapsedTime = 0;

            //Console.WriteLine("Type in a sentence: ");
            //string sentence = Console.ReadLine();

            //startTime = sw.ElapsedTicks;

            //Console.WriteLine("Total Words: " + sentence.Split().Length);

            //int i = 0;
            //foreach (string word in sentence.Split())
            //{
            //    if (userSearchHashTable.Contains(word))
            //    {
            //        userSearchHashTable[word] = i;
            //    }  
            //    else
            //        userSearchHashTable.Add(word, i);
            //}

            //foreach (DictionaryEntry entry in userSearchHashTable)
            //{
            //    Console.WriteLine("Word: " + entry.Key + " Appearance: " + entry.Value);
            //}

            //double totalMatched = 0;
            //string matchOne = "My computer wont turn on";
            //string matchTwo = "Chromebook screen is black";
            //string matchThree = "Lexia keeps asking for cookies";

            //foreach (string word in matchOne.Split())
            //{
            //    if (userSearchHashTable.ContainsKey(word))
            //    {
            //        //userSearchHashTable[word] = +1;
            //        //totalMatched = totalMatched + 2;
            //    }        
            //    else
            //        userSearchHashTable[word] = +0;
            //}

            //endTime = sw.ElapsedTicks;
            //elapsedTime = endTime - startTime;
            //Console.WriteLine("");

            //foreach (DictionaryEntry entry in userSearchHashTable)
            //{
            //    Console.WriteLine("Word: " + entry.Key + " Appearance: " + entry.Value);
            //}

            //Console.WriteLine("Total Time: " + string.Format("{0:0.##}", elapsedTime) + " ms.");
            //Console.WriteLine("Total Matched: " + totalMatched);


            Dictionary<string, int> input = new Dictionary<string, int>();

            Console.WriteLine("Write: ");
            string phrase = Console.ReadLine();
            int totalWord = phrase.Split().Length;
            string test = "computer wont turn on on on";

            foreach (string word in phrase.Split())
            {
                input.Add(word, 0);
            }   

            foreach (KeyValuePair<string,int> entry in input)
            {
                Console.WriteLine("Key: {0}    Value = {1}", entry.Key, entry.Value);
            }

            foreach (string word in test.Split())
            {
                if (input.ContainsKey(word))
                    input[word]++;
                else
                    input.Add(word, 0);
            }

            Console.WriteLine("");
            foreach (KeyValuePair<string, int> entry in input)
            {
                Console.WriteLine("Key: {0}    Value = {1}", entry.Key, entry.Value);
            }

            Console.WriteLine(input.Sum(total => total.Value));
            
        }
    }
}
