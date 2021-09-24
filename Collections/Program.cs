using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < numArray.Length; i++){
                Console.WriteLine(i);
            }

            string[] namesArray = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            for(int i = 0; i < namesArray.Length; i++){
                Console.WriteLine(namesArray[i]);
            }

            bool[] boolArray = new bool[10] {true,false,true,false,true,false,true,false,true,false};
            for(int i = 0; i < boolArray.Length; i++){
                Console.WriteLine(boolArray[i]);
            }


            List<string> iceCream = new List<string>() {"Chocolate", "Vanilla", "Strawberry", "Mint Chocolate Chip", "Neopolitan"};
            
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove("Strawberry");
            Console.WriteLine(iceCream.Count);
            
            foreach(string flavor in iceCream){
                Console.WriteLine(flavor);
            }

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            Random myFlavor = new Random();
            for(int i = 0; i < namesArray.Length; i++){
                myDictionary.Add(namesArray[i], iceCream[myFlavor.Next(0, iceCream.Count)]);
                }
            foreach(KeyValuePair<string, string> val in myDictionary){
                Console.WriteLine(val.Key + " : " + val.Value);
            }
            }
            

        }
    }
