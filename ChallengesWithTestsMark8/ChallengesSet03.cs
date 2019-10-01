using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals == null || vals.Length == 0)
            {
                return false;
            }
            foreach(var fact in vals)
            {
                if(fact == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            int total = 0;
            foreach(var number in numbers)
            {
                total += number;
            }
            if (total % 2 == 0)
                return false;

            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
         
            bool Upper = false;
            bool lower = false;
            bool Number = false;
            foreach (char character in password)
            {
                if(char.IsUpper(character))
                {
                    Upper = true;
                }
                if(char.IsLower(character))
                {
                    lower = true;
                }
                if(char.IsDigit(character))
                {
                    Number = true;
                }

            }
            if(Upper == true && lower == true && Number == true)
            {
                return true;
            }

            return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
                int[] ods = new int[50];
                int i = 0;
                int e = 1;
                do
                {
                    ods[i] = e;
                    e += 2;
                    i++;

                } while (e < 100);


                 return ods;
            
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
