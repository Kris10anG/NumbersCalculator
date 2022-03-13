using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodetime_28._02
{
    internal class numberProssesor
    {
        public int MostFrequentNumber(int[] numbers)
        {
            var count = 0;
            var mostnumbers = 0;
            var number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (count > mostnumbers)
                        {
                            mostnumbers = count;
                            number = numbers[i];
                        }
                    }
                }
                count = 0;

            }

            return number;
            //Console.WriteLine(number);
        }

        public int BiggestNumber(int[] numbers)
        {
            var biggestnumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (biggestnumber <= numbers[i])
                {
                    biggestnumber = numbers[i];
                }
            }

            return biggestnumber;
        }

        public int LowestNumber(int[] numbers)
        {
            var lowestnumber = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (lowestnumber >= numbers[i])
                {
                    lowestnumber = numbers[i];

                }
                
            }
            return lowestnumber;
        }

        public int Summary(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
              sum += numbers[i];
            }
            return sum;
        }
}
}
