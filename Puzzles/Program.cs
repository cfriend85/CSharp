using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
        }
        static int[] RandomArray()
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

    }
}
