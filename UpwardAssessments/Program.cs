using System;
using System.Collections.Generic;

namespace UpwardAssignments
{
    class Program
    {

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////// Check a string and checks that the brackets in the string are correct.
        static bool Brackets(string mathExpression)
        {
            Stack<char> openStack = new Stack<char>();

            foreach (char i in mathExpression)
            {
                switch (i)
                {
                    //Opening Brackets
                    case '{':
                        {
                            openStack.Push(i);
                            break;
                        }
                    case '(':
                        {
                            openStack.Push(i);
                            break;
                        }
                    case '[':
                        {
                            openStack.Push(i);
                            break;
                        }

                    //Closing Brackets
                    case '}':
                        {
                            if (openStack.Count == 0 || openStack.Peek() != '{')
                            {
                                return false;
                            }
                            else
                            {
                                openStack.Pop();
                                break;
                            }
                        }
                    case ')':
                        {
                            if (openStack.Count == 0 || openStack.Peek() != '(')
                            {
                                return false;
                            }
                            else
                            {
                                openStack.Pop();
                                break;
                            }
                        }
                    case ']':
                        {
                            if (openStack.Count == 0 || openStack.Peek() != '[')
                            {
                                return false;
                            }
                            else
                            {
                                openStack.Pop();
                                break;
                            }
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            return openStack.Count == 0;
        }

        //////////////////////////////////////////////////////////////////////////////////////
        ///////// Check n terms of harmonic series and their sum. /////////

        static void HarmonicSeries(double term)
        {
            double sum = 0;

            Console.WriteLine("\n\nThe Harmonic Series Upto The Entered Term is:");

            for (double i = 1; i <= term; i++)
            {
                Console.Write($" 1/{i} ");
                sum = sum + 1 / i;
            }
            Console.WriteLine($"\n\nThe Sum of Harmonic Series Upto The Entered Term is: {sum}");
        }

        //////////////////////////////////////////////////////////////////////////////////////
        ///////// Check n terms of harmonic series and their sum. /////////

        static void ConvertToBinary()
        {
            string result = "";
            int rem = 0;
            Console.Write("Enter a Decimal to Convert it into Binary: ");
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                rem = num % 2;
                num = num / 2;
                result = rem.ToString() + result;
            }
            Console.WriteLine(result);
        }


        //////////////////////////////////////////////////////////////////////////////////////
        ///////// Censored Vowel String To Uncensored Vowel String /////////
        static void CensoredVowelsString(string censoredString, string censoredVowels)
        {
            string uncensoredString = "";
            int i = 0;
            int j = 0;

            while (i < censoredString.Length)
            {
                char currentCharacter = censoredString[i];

                if (currentCharacter == '*')
                {
                    uncensoredString += censoredVowels[j];
                    j++;
                }
                else
                {
                    uncensoredString += currentCharacter;
                }
                i++;
            }
            Console.WriteLine(uncensoredString);
        }


        //////////////////////////////////////////////////////////////////////////////////////
        ///////// Longest Common Ending /////////
        static string CommonEnding(string word1, string words2)
        {
            string longestCommonEnding;
            for (int i = 0; i <= word1.Length; i++)
            {
                longestCommonEnding = word1.Substring(i);

                if (words2.EndsWith(Convert.ToString(longestCommonEnding)))
                {
                    return longestCommonEnding;
                }
            }
            return "";
        }


        /////////////////////////////////////////
        ///////// Main Function /////////
        static void Main(string[] args)
        {

            ////Longest Common Ending
            //Console.Write("Enter First Word: ");
            //string word1 = Console.ReadLine();
            //Console.Write("Enter Second Word: ");
            //string word2 = Console.ReadLine();

            //Console.WriteLine("\nThe Longest Common Ending is: "+CommonEnding(word1, word2));

            ////Censored Vowel String
            CensoredVowelsString("Wh*r* d*d my v*w*ls g*?", "eeioeo");
            Console.WriteLine("Hello World");

            ////Convert Decimal to Binary 
            //ConvertToBinary();

            ////Harmonic Series 

            //Console.Write("Enter the term upto which you want to find the Harmonic Series: ");
            //double term = double.Parse(Console.ReadLine());
            //HarmonicSeries(term);


            //// Check Validity of String to Validate No of Brackets

            //Console.Write("Enter a String with Brackets to Check it Valadity:  ");
            //string mathExpression = Console.ReadLine();
            //Brackets(mathExpression);
            //bool Result = Brackets(mathExpression);

            //if (Result)
            //{
            //    Console.WriteLine($"\n{mathExpression} : Expression is Valid.");
            //}
            //else
            //{
            //    Console.WriteLine($"\n{mathExpression} : Expression is not valid.");
            //}

            Console.ReadLine();
        }
    }
}
