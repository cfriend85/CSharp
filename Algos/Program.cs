﻿using System;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algos!");
            Console.WriteLine(addChar(29));
            Console.WriteLine(adjacentProduct(new int[] {1,2,3,4,5}));
            Console.WriteLine(angryProfessor(3, new int[] {-1,-3,4,2}));
            Console.WriteLine(binarySearch(new int[] {1, 3, 8, 10, 12, 15, 17, 20, 22, 34, 38, 40, 50, 52, 78, 87, 90, 91, 92, 94, 200}, 52));
        }

        public static int addChar(int n)
        {
            int sum = 0;
            string myNum = string.Join(", ", n);
            for(int i = 0; i < myNum.Length; i++){
                int num = (int)Char.GetNumericValue(myNum[i]);
                sum += num;
            }
            return sum;
        }

        public static int adjacentProduct(int[] numbers)
        {
            int product = numbers[0] * numbers[1];
            for(int i = 1; i < numbers.Length-1; i++){
                if (numbers[i] * numbers[i+1] > product)
                {
                    product = numbers[i] * numbers[i+1];
                }
            }
            return product;
        }

        public static string angryProfessor(int k, int[] arrivalTimes)
        {
            int count = 0;
            for(int i = 0; i < arrivalTimes.Length; i++)
            {
                if (arrivalTimes[i] <= 0)
                {
                    count += 1;
                }
            }
            return count < k ? "YES" : "NO";
        }

        public static int binarySearch(int[] array, int num)
        {
            int left = array[0];
            int right = array.Length;
            while (left <= right)
            {
                int center = left + (right - left) / 2;
                if (num == array[center])
                {
                    return center;
                }
                if (num < array[center])
                {
                    right = center - 1;
                } else
                {
                    left = center + 1;
                }
            }
            return -1;
        }
    }
}
