using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Statistics
    {
        public List<int> AllLotteryNumbers { get; set; }
        public int MostCommonNumber { get; set; }
        public int SecondMostCommonNumber { get; set; }
        public int ThirdMostCommonNumber { get; set; }
        //public int MaxOccurences { get; set; }
        public int LessCommonNumber { get; set; }
        public int SecondLessCommonNumber { get; set; }
        public int ThirdLessCommonNumber { get; set; }
        //public int MinOccurences { get; set; }

        public Statistics()
        {
            AllLotteryNumbers = new List<int>();
            MostCommonNumber = 0;
            SecondMostCommonNumber = 0;
            ThirdMostCommonNumber = 0;
            LessCommonNumber = 0;
            SecondLessCommonNumber = 0;
            ThirdLessCommonNumber = 0;
        }

        public void MaxOccurrence()
        {
            var counterDictionary = new Dictionary<int, int>();
            var tempList = new List<int>();
            foreach (int number in AllLotteryNumbers)
            {
                int counter; //create a counter to count how many times a number exists in the list
                counterDictionary.TryGetValue(number, out counter);
                counter++;

                counterDictionary[number] = counter; //add the counter to each number accordingly

            }
            foreach (KeyValuePair<int, int> pair in counterDictionary.OrderByDescending(i => i.Value))
            {
                tempList.Add(pair.Key);
                Console.WriteLine("Number {0} appeared {1} times", pair.Key, pair.Value);
                
            }
            MostCommonNumber = tempList[0];
            SecondMostCommonNumber = tempList[1];
            ThirdMostCommonNumber = tempList[2];
            Console.WriteLine("\nThe most common number is: {0}", MostCommonNumber);
            Console.WriteLine("\nThe second most common number is: {0}", SecondMostCommonNumber);
            Console.WriteLine("\nThe third most common number is: {0}", ThirdMostCommonNumber);

        }

        public void MinOccurrence()
        {
            var counterDictionary = new Dictionary<int, int>();
            var tempList = new List<int>();
            foreach (int number in AllLotteryNumbers)
            {
                int counter;
                counterDictionary.TryGetValue(number, out counter);
                ++counter;

                counterDictionary[number] = counter;
            }
            foreach (KeyValuePair<int, int> pair in counterDictionary.OrderBy(i => i.Value))
            {
                tempList.Add(pair.Key);
  
            }
            LessCommonNumber = tempList[0];
            SecondLessCommonNumber = tempList[1];
            ThirdLessCommonNumber = tempList[2];
            Console.WriteLine("\nThe least common number is: {0}", LessCommonNumber);
            Console.WriteLine("\nThe second least common number is: {0}", SecondLessCommonNumber);
            Console.WriteLine("\nThe third least common number is: {0}", ThirdLessCommonNumber);

        }
    }
}
