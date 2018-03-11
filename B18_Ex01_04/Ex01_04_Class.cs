using System;
using System.Linq;

namespace B18_Ex01_04
{
    public class Ex01_04_Class
    {
        public static void Ex01_04_Start()
        {
            Console.WriteLine("Hey, Ex01_04 !");
            string inputString = StringInput();
            string answer = IsPalindrome(inputString) ? "a" : "not";
            Console.WriteLine("The String {0} is {1} Palindrome.", inputString , answer);            
            if (char.IsDigit(inputString[0])) // check if the string is a numbers or letters .
            {
                Console.WriteLine("The number is {0}", IsEven(inputString) ? "even" : "odd");
            }
            else
            {
                Console.WriteLine("String is {0} , lower letter count is -> {1}", inputString, LowerLetterCounter(inputString));
            }           
        }
               
        public static byte LowerLetterCounter(string i_StringToCheck)
        {
            byte lowLetterCounter = (byte)i_StringToCheck.LongCount(char.IsLower);
            return lowLetterCounter;
        }

        public static string StringInput()
        {
            bool quit = false;
            string input = null;

            while (!quit)
            {
                Console.WriteLine(
@"Please insert string length 8 character.
Only number or Only letters. then press 'enter' .");
                input = Console.ReadLine();
                if ((input.All(char.IsLetter) || input.All(char.IsDigit)) && input.Length == 8)
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                    quit = false;
                }
            }

            return input;
        }

        public static bool IsEven(string i_Number)
        {
            char lastDig = i_Number[i_Number.Length - 1];
            byte digit = (byte)char.GetNumericValue(lastDig);
            return digit % 2 == 0;
        }

        public static bool IsPalindrome(string i_StringToCheck)
        {
            bool answer = true;
            int midle = i_StringToCheck.Length / 2;
            for (int i = 0, k = i_StringToCheck.Length - 1; i < midle; i++, k--)
            {
                if (i_StringToCheck[i] != i_StringToCheck[k])
                {
                    answer = false;
                    break;
                }
            }

            return answer;
        }
    }
}
