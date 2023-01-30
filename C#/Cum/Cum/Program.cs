using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(rnd.Next(10, 101));
            }

            for (int i = 0; i < randomNumbers.Count; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }

            
            List<int> twoDigitNumbers = new List<int>();
            int number1 = rnd.Next(10, 100);
            int number2 = rnd.Next(10, 100);
            while (number1 >= 20 || number2 >= 20)
            {
                twoDigitNumbers.Add(number1);
                number1 = number2;
                number2 = rnd.Next(10, 100);
            }
            twoDigitNumbers.Reverse();
            foreach (int number in twoDigitNumbers)
            {
                Console.WriteLine(number);
            }

            
            List<int> numbers = File.ReadAllLines("szamok.txt").Select(x => Convert.ToInt32(x)).ToList();
            int fiftyCount = 0;
            int fiftyIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 50)
                {
                    fiftyCount++;
                    if (fiftyIndex == -1)
                    {
                        fiftyIndex = i;
                    }
                }
            }
            if (fiftyCount == 0)
            {
                Console.WriteLine("There is no 50 in the list.");
            }
            else
            {
                Console.WriteLine("The first 50 is at index: " + fiftyIndex);
                Console.WriteLine("The number of 50s is: " + fiftyCount);
            }

            
            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] % 2 == 0)
                {
                    numbers[i] /= 2;
                }
            }
            
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int sum = numbers.Sum();
            Console.WriteLine("The sum is: " + sum);

            double average = numbers.Average();
            Console.WriteLine("The average is: " + average);

            int max = numbers.Max();

        }
    }
}
