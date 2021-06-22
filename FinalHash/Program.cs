using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHash
{
    class Program
    {
        static void Main(string[] args)
        {

            String path = @"";
            //Trys to catch any exceptions
            try
            { 
                //Reads in the file and turns it into an array
                string[] file1 = File.ReadAllLines(path);

                //Checks if file is empty
                if (file1.Length <= 0) { Console.WriteLine("File is Empty"); Console.ReadLine(); return; }

                //Creates Hash table
                Hashtable hashtable1 = new Hashtable();

                //Big O Notation for this (Foreach Loop) 
                //Best: O(N) Since it needs to loop through the array and add the contents to the hash table just once
                //Average : O(N) It needs to loop through an array.

                foreach (string lines in file1)
                {
                    //Checks if there already is a key in hash table
                    if (hashtable1.ContainsKey(lines))
                    {
                        //If there is then it adds 1 to the vaule of the key already in
                        hashtable1[lines] = (int)hashtable1[lines] + 1;
                    }
                    else
                    {
                        //else adds in the key and value
                        hashtable1.Add(lines, 1);
                    }
                }
                //Creates Varabiles for Max Frequency
                int count = 0;
                string name = "";

                Console.WriteLine("Hash Table: ");

                //Big O Notation for this (Foreach Loop)
                //Best: O(1) Loops through hash table and finds the single value
                //Average: O(N) Needs to loop through hash table and check every value
                //Worst: O(N) Needs to loop through hash table and check every value
                foreach (DictionaryEntry ele1 in hashtable1)
                {
                    //Checks hash table values if its greater than max
                    if ((int)ele1.Value > count)
                    {
                        //if hash table values greater than max, then set as variables
                        name = (string)ele1.Key;
                        count = (int)ele1.Value;
                    }
                    //Prints Hash table
                    Console.WriteLine("String: " + ele1.Key + ", Amount: " + ele1.Value);
                }

                Console.WriteLine(); Console.WriteLine("============================"); Console.WriteLine();

                //Big O Notation for this (Foreach Loop)
                //Best: O(1) Loops through hash table and finds the single value
                //Average: O(N) Needs to loop through hash table and check every value
                //Worst: O(N)  Needs to loop through hash table and check every value
                foreach (DictionaryEntry ele2 in hashtable1)
                {
                    if((int)ele2.Value == count)
                    {
                        Console.WriteLine("Most Frequent String: " + ele2.Key + " Amount:  " + ele2.Value);
                    }
                }


                //Prints Values
                
                Console.ReadKey();

            }
            //If any errors, this will print to console
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadLine(); }

        }
    }
}