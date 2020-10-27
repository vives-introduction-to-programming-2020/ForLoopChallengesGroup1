using System;

namespace ForLoopChallenges
{
    class Program
    {
        // Table of multiplication
        public static void OutputTableOfMultiplication
            (int baseNumber, int range)
        {
            for (int i = 0; i <= range; i++)
            {
                Console.WriteLine($"{i} x {baseNumber} = " +
                    $"{(i * baseNumber)}");
            }
        }

        // Counting the number of spaces in a string
        public static int CountNumberOfSpaces
            (string input)
        {
            int numberOfSpaces = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // Using [] we can index each character in the string
                if (input[i] == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        // Converting a string representation of a number into an integer
        // 5324 =
        // 4 * 1        = 10^0
        // 2 * 10       = 10^1
        // 3 * 100      = 10^2
        // 5 * 1000     = 10^3
        // RESULTING SUM = original
        //
        // But we don't want to use Math.pow().
        // Instead we store 1 ... 10000 as an integer (weight) which
        // we multiply by 10 every for-iteration

        public static int ConvertToInteger
            (string input)
        {
            int result = 0;     // End result
            int weight = 1;     // 10^exp

            for (int i = input.Length-1; i >= 0; i--)
            {
                // '0' actually has an ASCII value of 48
                // (internal representation of '0')
                // So to get integer 3 from character '3',
                // we can subtract the value of '0' from '3':
                // '3' - '0' = 3
                int digitValue = input[i] - '0';

                result = result + digitValue * weight;
                weight = weight * 10;
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            OutputTableOfMultiplication(6, 30);

            string text = "Hello world from C# by Nico";
            int numberOfSpaces = CountNumberOfSpaces(text);

            Console.WriteLine($"The string \"{text}\" " +
                $" has {numberOfSpaces} spaces");

            Console.WriteLine("'5' - '0' = " + (int)('5' - '0'));

            Console.WriteLine($"{ConvertToInteger("421223")+1}");
        }
    }
}
