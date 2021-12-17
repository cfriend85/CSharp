using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic 13!");
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(new int[5] {1,2,3,4,5});
            Console.WriteLine(FindMax(new int[10] {5,15,-1,25,88,-3,15,-2,157,0}));
            GetAverage(new int[] {1,2,3,4,5});
            Console.WriteLine(OddArray());
            Console.WriteLine(GreaterThanY(new int[] {15,33,1,25,152,89,99,12,0,18,22,37}, 15));
            SquareArrayValues(new int[] {1,5,10,-10});
            EliminateNegatives(new int[] {1,5,10,-2});
            MinMaxAverage(new int[] {1,2,3,4,5});
            ShiftValues(new int[] {1,5,10,7,-2});
            NumToString(new int[] {-1,-3,2});
        }
        public static void PrintNumbers()
        {
            for(int i = 0; i < 256; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for(int i = 0; i < 256; i++){
                if(i % 3 == 0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i < 256; i++){
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach(int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = numbers[0];
            foreach(int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum / numbers.Length);
        }
        public static int[] OddArray()
        {
            int[] odds = new int[86];
            int count = 0;
            for(int i = 0; i < 256; i++){
                if(i % 3 == 0){
                    odds[count] = i;
                    count += 1;
                }
            }
            Console.WriteLine(string.Join(", ", odds));
            return odds;   
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach(int num in numbers)
            {
                if (num > y)
                {
                    count++;
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = numbers[0];
            foreach(int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                    sum += num;
                } else if (num > max)
                {
                    max = num;
                    sum += num;
                } else
                {
                    sum += num;
                }
            }
            Console.WriteLine($"min: {min}");
            Console.WriteLine($"max: {max}");
            Console.WriteLine($"avg: {sum / numbers.Length}");
        }
        public static void ShiftValues(int[] numbers)
        {
            Array.Copy(numbers, 1, numbers, 
            0, numbers.Length -1);
            numbers[numbers.Length -1] = 0;
            Console.WriteLine(string.Join(", ", numbers));
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] objNumbers = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    objNumbers[i] = "Dojo";
                }
                else{
                    objNumbers[i] = numbers[i];
                }
            }
            Console.WriteLine(string.Join(", ", objNumbers));
            return objNumbers;
        }
    }
}
