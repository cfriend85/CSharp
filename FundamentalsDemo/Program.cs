using System;
using System.Collections.Generic;

namespace FundamentalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Howdy = "Hello World";
            int Num = 7;
            bool Fact = true;

            // to declare an array you must declare its data type and you MUST declare how many indices there will be.
            int[] numArray = new int[5] {1,2,3,4,5};
            numArray[3] = 21; //you can change values within the array but you CANNOT change the SIZE of the array. (NO .push() or .pop())
            // If you were to do Console.WriteLine(numArray) you would get back its TYPE not it's values.
            // To see the values you need to loop over it.
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            
            //  LISTS
            List<string> names = new List<string>();
            names.Add("Charles");
            names.Add("John");
            names.Add("Clark");
            names.Add("Paxtonian");
            names.Remove("Paxtonian"); //This only removes the first instance of the matching search query.
            names.RemoveAt(2); //this will remove the value at the index specified
            names.Insert(0, "Batman"); //insert at particular index location. 
            
            // iterate over list with FOREACH method making sure to declare the type of the thing you're wanting to return, 
            // foreach loop does not give index values!!!
            foreach(string name in names)
            {
                Console.WriteLine($"Your name is {name}.");
            }

            Console.WriteLine(String.Join(", ", names)); //print all names on one line separated by commas
            Console.WriteLine(Howdy);
            Console.WriteLine(Num);
            Console.WriteLine(Fact);
            Console.WriteLine(names[0]);


            //  DICTIONARIES
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("One", 1);
            myDictionary.Add("Two", 2);

            Console.WriteLine($"The value at One is: {myDictionary["One"]}");


            foreach(KeyValuePair<string, int> val in myDictionary)
            {
                Console.WriteLine(val.Key + " : " + val.Value);
            }

            foreach(var val in myDictionary)
            {
                Console.WriteLine(val.Key + " : " + val.Value);
            }

            int result = DiceRoll();
            while(result != 5)
            {
                if(result == 3)
                {
                    Console.WriteLine("Threeeeeeeeee!");
                }
                else if (result == 1)
                {
                    Console.WriteLine("Uno!");
                }
                else {
                    Console.WriteLine("Try Again");
                }
                // Console.WriteLine("You rolled: " + result);
                result = DiceRoll();
            }
            Console.WriteLine("You rolled 5!");
        }

        static int DiceRoll()
        {
            Random rand = new Random();
            return rand.Next(1,7);
        }
    }
}
