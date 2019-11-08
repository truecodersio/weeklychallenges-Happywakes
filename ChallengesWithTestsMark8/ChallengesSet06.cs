using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;
            foreach (var wor in words)
            {
                if (wor != null && words != null)
                {
                    if (ignoreCase == true && wor.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                    else if (ignoreCase == false && wor == word)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
            
            
        }

        public bool IsPrimeNumber(int num)
        {
            
            if (num <= 1) return false;
            for (int i=2; i< num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int counter = 0;
            int last = 0;
            if(str == "")
            {
                return -1;
            }

            int[] counts = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foreach(var letter in str)
                {

                    if(str[i] == letter)
                    {
                        counts[i]++;
                    }
                }
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if(counts[i] == 1)
                {
                    last = i; 
                }
                else if(counts[i] > 1)
                {
                    counter++;
                }
            }
            if(counter == str.Length)
            {
                return -1;
            }
            return last;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            
            if (numbers == null || numbers.Length == 0) return 0;
            int previousNumber = numbers[0];
            int currentConsecutive = 1;
            int currentMaxConsecutive = 0;

            for (int i = 1; i<numbers.Length;i++)
            {
                if (numbers[i] == previousNumber)
                { 
                    currentConsecutive++;
                }
                if (currentConsecutive > currentMaxConsecutive)
                {

                    currentMaxConsecutive = currentConsecutive;
                }
                if (numbers[i] != previousNumber)
                {
                    currentConsecutive = 1;

                }
                previousNumber = numbers[i];
            }
            return currentMaxConsecutive;


            /*int count = 0;
            int max = 1;
            for (int i = 0; i > numbers.Length; i++)
            {
                for (int j = 0; j > numbers.Length; j++)
                {
                    

                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (count > max)
                        {

                            max += count; 

                        }

                    }
                    else if(numbers[i] != numbers[j])
                    {
                        count = 0;
                    }
                }
            }

            return max;   couldnt make it work :(*/
           

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 0) return new double[0];
            List<double> nth = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    nth.Add(elements[i-1]);
                }
            }
            return nth.ToArray();
        }
    }
}
