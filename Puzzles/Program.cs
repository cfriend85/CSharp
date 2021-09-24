using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // Console.WriteLine(TossCoin());
            // TossMultipleCoins(5);
            Names();
        }
        public static int[] RandomArray()
        {
        int[] randArray = new int[10];
        Random rand = new Random();
        int min = 25;
        int max = 0;
        int sum = 0;
        for(int i = 0; i < randArray.Length; i++){
            randArray[i] = rand.Next(5, 26);
            if(randArray[i] < min){
                min = randArray[i];
                sum += randArray[i];
            }
            else if(randArray[i] > max){
                max = randArray[i];
                sum += randArray[i];
            }
            else{
                sum += randArray[i];
            }
        }
        Console.WriteLine(string.Join(", ", randArray));
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(sum);
        return randArray;
        }

        public static string TossCoin()
        {
            string result = "Heads";
            Random toss = new Random();
            if(toss.Next(0, 2) == 0){
                result = "Heads";
            }
            else{
                result = "Tails";
            }
            return result;
        }
        public static double TossMultipleCoins(int num)
        {
            int HeadCount = 0;
            for(int i = 0; i < num; i++){
                string result = TossCoin();
                if(result == "Heads"){
                    HeadCount += 1;
                }
            }
            double ratio = (double)HeadCount / num;
            Console.WriteLine($"Heads ratio is {ratio}");
            return ratio;
        }

        public static List<string> Names()
        {
            List<string> ClassNames = new List<string>() {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random random = new Random();
            for(int i = 0; i < ClassNames.Count; i++){
                int rnd = random.Next(i + 1);
                string value = ClassNames[rnd];
                ClassNames[rnd] = ClassNames[i];
                ClassNames[i] = value;
            }
            
        
            foreach(string name in ClassNames)
            {
                Console.WriteLine(name);
            }
            ClassNames.RemoveAll(name => name.Length <= 5);
            return ClassNames;
        }
    }
}
