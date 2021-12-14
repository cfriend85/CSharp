using System;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algos!");
            Console.WriteLine(addChar(29));
            Console.WriteLine(adjacentProduct(new int[] {1,2,3,4,5}));
            Console.WriteLine(adjacentProduct(new int[] {-23, 4, -3, 8, -12}));
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
    }
}
