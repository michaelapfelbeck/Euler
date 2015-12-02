using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem17:EulerProblem
    {
        private static string format = "The sum of all the letters in the word forms of 1 to one thousand is {0}.";
        private static int min = 1;
        private static int max = 1000;

        protected override void SetProblemText()
        {
            problemText = "Problem 17:\nIf the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.\n\nIf all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?\n\nNOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of \"and\" when writing out numbers is in compliance with British usage.";
        }

        public override void Run()
        {
            result = 0;
            for (int i = min; i <= max; i++)
            {
                string asString = WordFromThousands(i);
                int letterCount = asString.Length;
                result += letterCount;
                Console.WriteLine("Int {0} writen as '{1}'",i,WordFromThousands(i));
            }

            stringResult = String.Format(format, result);
        }

        private string WordFromThousands(int number)
        {
            string result = "";

            int thousands = number / 1000;
            string thousandsStr = WordFromOnes(thousands);
            int hundreds = number % 1000;
            string hundredsStr = WordFromHundereds(hundreds);

            if (thousands > 0)
            {
                result += (thousandsStr+"thousand");
            }
            if (hundreds > 0)
            {
                result += hundredsStr;
            }
            
            //result = string.Format("1000:{0} 100:{1}", thousandsStr, hundredsStr);

            return result;
        }

        private string WordFromHundereds(int number)
        {
            string result = "";

            int hundreds = number / 100;
            string hundredsStr = WordFromOnes(hundreds);

            int tens = number % 100;
            string tensStr = WordFromTens(tens);

            if (hundreds > 0)
            {
                result += (hundredsStr + ("hundred"));
            }
            if (tens > 0)
            {
                if (hundreds > 0)
                {
                    result += ("and" + tensStr);
                }
                else
                {
                    result += tensStr;
                }
            }
            //result = string.Format("100:{0} 10:{1}", hunderedsStr, tensStr);

            return result;
        }

        private string WordFromTens(int number)
        {
            string result = "";

            if (number < 20)
            {
                result = WordFromOnes(number);
            }
            else
            {
                int tens = number/10;
                string tensStr = "";
                if (tens > 1)
                {
                    switch (tens)
                    {
                        case 2:
                            tensStr = "twenty";
                            break;
                        case 3:
                            tensStr = "thirty";
                            break;
                        case 4:
                            tensStr = "forty";
                            break;
                        case 5:
                            tensStr = "fifty";
                            break;
                        case 6:
                            tensStr = "sixty";
                            break;
                        case 7:
                            tensStr = "seventy";
                            break;
                        case 8:
                            tensStr = "eighty";
                            break;
                        case 9:
                            tensStr = "ninety";
                            break;
                        default:
                            break;
                    }
                }
                int ones = number%10;
                string onesStr = WordFromOnes(ones);
                if (tens > 0)
                {
                    result += tensStr;
                }
                if (ones > 0)
                {
                    result += onesStr;
                }
                //result = string.Format("10:{0} 1:{1}", tensStr, onesStr);

            }

            return result;
        }

        private string WordFromOnes(int number)
        {
            string result = "";

            switch (number)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                case 10:
                    result = "ten";
                    break;
                case 11:
                    result = "eleven";
                    break;
                case 12:
                    result = "twelve";
                    break;
                case 13:
                    result = "thirteen";
                    break;
                case 14:
                    result = "fourteen";
                    break;
                case 15:
                    result = "fifteen";
                    break;
                case 16:
                    result = "sixteen";
                    break;
                case 17:
                    result = "seventeen";
                    break;
                case 18:
                    result = "eighteen";
                    break;
                case 19:
                    result = "nineteen";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
