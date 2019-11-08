using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    total += item;
                }
                else
                {
                    total -= item;
                }
            }

            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] numbers = {str1.Length, str2.Length, str3.Length, str4.Length };
            int smallest = str1.Length + str2.Length + str3.Length + str4.Length;
            int now = 0;
            foreach(var number in numbers)
            {
                now = number;
                if(now < smallest)
                {
                    smallest = now;
                }
            }

            return smallest;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            int smallest = number1 + number2 + number3 + number4;
            int now = 0;
            foreach (var number in numbers)
            {
                now = number;
                if (now < smallest)
                {
                    smallest = now;
                }
            }

            return smallest;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var triangle = new int[] { sideLength1, sideLength2, sideLength3 };
            foreach(var side in triangle)
            {
                if(side <= 0)
                {
                    return false;
                }
                
            }
            if(sideLength3 + sideLength2 > sideLength1
                && sideLength2 + sideLength1 > sideLength3
                && sideLength3+ sideLength1 > sideLength2)
            {
                return true;
            }

            return false;
            /* in class better solution
             reutrn (
                sideLength3 + sideLength2 > sideLength1
                && sideLength2 + sideLength1 > sideLength3
                && sideLength3+ sideLength1 > sideLength2
             )*/
        }

        public bool IsStringANumber(string input)
        {
            if(input == null || input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == true || input.Contains('.') || input.Contains('-'))
                {
                    
                }
                else
                { 
                    return false;
                }
            }
            return true;
            /* in class better solution
             return double.TryParse(input, out double number);
             */


        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counter = 0;
            foreach(var item in objs)
            {
                if(item == null)
                {
                    counter++;
                }

            }
            if(counter > objs.Length / 2)
            {
                return true;
            }

            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            double averagetotal = 0;
            double counter = 0;
            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    averagetotal += number;
                    counter++;
                }
            }

            if(counter == 0)
            {
                return 0;
            }
            return averagetotal / counter;
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            
            return number * Factorial(number - 1);

            /* in class solution
             var fact = 1;
             for(int i = number; i > 0; i--)
             {
              fact*= i;
             }
             return fact;*/ 

        }
    }
}
