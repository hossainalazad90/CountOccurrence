using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurrenceFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string value: ");
            string inputValue = Console.ReadLine();
            inputValue = inputValue.Replace(" ", string.Empty);
            while (inputValue.Length > 0)
            {
                Console.Write(inputValue[0] + "-");
                int count = 0;
                for (int j = 0; j < inputValue.Length; j++)
                {
                    if (inputValue[0] == inputValue[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                inputValue = inputValue.Replace(inputValue[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}
