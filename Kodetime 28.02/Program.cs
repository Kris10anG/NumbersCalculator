using System;

namespace Kodetime_28._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 4};
            var numberprossesor = new numberProssesor();
            var mostFrequentNumber = numberprossesor.MostFrequentNumber(numbers);
            Console.WriteLine("Mest gjentatte nummer " + mostFrequentNumber);

            var BiggestNumber = numberprossesor.BiggestNumber(numbers);
            Console.WriteLine("Høyeste nummer " + BiggestNumber);

            var LowestNumber = numberprossesor.LowestNumber(numbers);
            Console.WriteLine("Laveste nummer " + LowestNumber);

            var summary = numberprossesor.Summary(numbers);
            Console.WriteLine("Summen av listen er " + summary);


        }

    }
}
