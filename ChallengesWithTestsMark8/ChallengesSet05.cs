using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return n + startNumber - (startNumber % n);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var business in businesses)
            {
                if(business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i -1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            var tunafish = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {

                if(numbers[i] % 2 == 0)
                {
                    tunafish += numbers[i + 1];
                }
            }
            return tunafish;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //
            if(words == null || words.Length == 0 || words.Length == 1)
            {
                return "";
            }
            string wordy = "";
            int count = 0;
            foreach(var st in words)
            {
               if(st == " " || st == "")
                {
                    count++;continue;
                }
                string addition = st.Replace(" ","");
                wordy += addition;
                if (count < words.Length - 1 && addition != "") wordy += " ";
                else if (count == words.Length - 1) wordy += ".";

                count++;
            }
            return wordy;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            // 
            if (elements == null) return new double[0];
            List<double> fourth = new List<double>();

            for (int i =1; i <= elements.Count;i++)
            {
                if (i % 4 == 0)
                {
                    fourth.Add(elements[i - 1]);
                }
            }
            return fourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 0 || nums.Length == 1) return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;

                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;


                    }
                }
            }


            return false;
        }
    }
}
