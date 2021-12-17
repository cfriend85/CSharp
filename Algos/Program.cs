using System;
using System.Text.RegularExpressions;
namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("JavaScript Algos To C#!");
            // Console.WriteLine(addChar(29));
            // Console.WriteLine(adjacentProduct(new int[] {1,2,3,4,5}));
            // Console.WriteLine(angryProfessor(3, new int[] {-1,-3,4,2}));
            // Console.WriteLine(binarySearch(new int[] {1, 3, 8, 10, 12, 15, 17, 20, 22, 34, 38, 40, 50, 52, 78, 87, 90, 91, 92, 94, 200}, 52));
            // Console.WriteLine(birthdayCakeCandles(new int[] {3,2,1,3}));
            // Console.WriteLine(camelCase("saveChangesInTheEditor"));
            // Console.WriteLine(catAndMouse(2,5,4));
            // compareTriplets(new int[] {5,6,7}, new int[] {3,6,10});
            // Console.WriteLine(peaksAndValleys(8, "UDDDUDUU"));
            // Console.WriteLine(findDigits(1012));
            // Console.WriteLine(interestingPolygon(3));
            // Console.WriteLine(isPalindrome("aabaa"));
            // Console.WriteLine(miniMaxSum(new int[] {1,2,3,4,5}));
            plusMinus(8, new int[] {1,2,3,-1,-2,-3,0,0});
            // Console.WriteLine(secondLargest(new int[] {5,15,77,64,31,99,45,17,0,25,1,65,148}));
            // Console.WriteLine(simpleArraySum(new int[] {1,2,3,4,5}));
        }

        public static int addChar(int n)
        {
            int sum = 0;
            string myNum = string.Join(", ", n);
            foreach(char s in myNum)
            {
                int num = (int)Char.GetNumericValue(s);
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
            foreach(int i in arrivalTimes)
            {
                if (i <= 0)
                {
                    count++;
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

        public static int birthdayCakeCandles(int[] candles)
        {
            Array.Sort(candles);
            int count = 0;
            int max = 0;
            foreach(int i in candles)
            {
                if (i > max)
                {
                    max = i;
                    count = 1;
                } else if (i == max)
                {
                    count++;
                }
            }
            return count;
        }

        public static int camelCase(string s)
        {
            int count = 1;
            Regex rx = new Regex("[A-Z]");
            foreach(char c in s)
            {
                MatchCollection matches = rx.Matches(char.ToString(c));
                foreach(Match match in matches)
                {
                    count++;
                }
            }
            return count;
        }

        public static string catAndMouse(int x, int y, int z)
        {
            int CatA = z-x;
            int CatB = z-y;
            if (CatA > CatB)
            {
                return "Cat B";
            } else if (CatB > CatA)
            {
                return "Cat A";
            } else
            {
                return "Mouse C";
            }
        }

        public static object[] compareTriplets(int[] a, int[] b)
        {
            int alice = 0;
            int bob = 0;
            for(int i = 0; i < b.Length; i++)
            {
                if (a[i] > b[i])
                {
                    alice += 1;
                } else if (b[i] > a[i])
                {
                    bob += 1;
                } else
                {
                    Console.WriteLine("Tie!");
                }
            }
            object[] result = new object[2] {alice, bob};
            Console.WriteLine(string.Join(", ", result));
            return result;
        }

        public static int peaksAndValleys(int steps, string path)
        {
            int valleys = 0;
            int count = 0;
            foreach(char c in path)
            {
                if (c.ToString() == "U" && count == 0)
                {
                    valleys++;
                }
                if (c.ToString() == "U")
                {
                    count++;
                } else
                {
                    count--;
                }
            }
            return valleys;
        }

        public static int findDigits(int n)
        {
            string myNum = string.Join(", ", n);
            int count = 0;
            foreach(char c in myNum)
            {
                if (n % Char.GetNumericValue(c) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int interestingPolygon(int n)
        {
            int test = ((n-1) * (n-1));
            int result = test + n * n;
            return result;
        }


        public static bool isPalindrome(string inputString)
        {
            for(int i = 0; i < inputString.Length; i++)
            {
                for(int j = inputString.Length-1; j > 0; j--)
                {
                    if (inputString[i] == inputString[j])
                    {
                        i += 1;
                    } else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static object[] miniMaxSum(int[] numbers)
        {
            Array.Sort(numbers);
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            object[] result = new object[] {sum - numbers[4], sum - numbers[0]};
            return result;
        }

        public static void plusMinus(int n, int[] numbers)
        {
            int x = numbers.Length;
            int pos = 0;
            int neg = 0;
            int zero = 0;
            foreach(int num in numbers)
            {
                if (num > 0)
                {
                    pos += 1;
                } else if (num < 0)
                {
                    neg += 1;
                } else
                {
                    zero += 1;
                }
            }
            double posRatio = (double)pos / n;
            double negRatio = (double)neg / n;
            double zeroRatio = (double)zero / n;
            Console.WriteLine(posRatio.ToString("N6"));
            Console.WriteLine(negRatio.ToString("N6"));
            Console.WriteLine(zeroRatio.ToString("N6"));
        }

        public static int secondLargest(int[] numbers)
        {
            int large = numbers[0];
            int secLarge = numbers[0];
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > large)
                {
                    secLarge = large;
                    large = numbers[i];
                } else if (numbers[i] > secLarge && numbers[i] < large)
                {
                    secLarge = numbers[i];
                }
            }
            return secLarge;
        }

        public static int simpleArraySum(int[] numbers)
        {
            int sum = 0;
            foreach(int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
