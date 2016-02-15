using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            else if (!numbers.Contains(","))
                return int.Parse(numbers);
            else
                return AddNumbers(numbers);
        }

        private int AddNumbers(string numbers)
        {
            string[] splitNumbers = GetRegexArray(numbers);
            return AddArrayContents(splitNumbers);
        }

        private int AddArrayContents(string[] splitNumbers)
        {
            bool result;
            int sum = 0;
            int number;
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                result = int.TryParse(splitNumbers[i], out number);
                if (number < 0)
                    throw new NoNegativesAllowedException();
                if (result)
                    sum += int.Parse(splitNumbers[i]);
            }
            return sum;
        }

        private string[] GetRegexArray(string numbers)
        {
            string pattern = @"(,)|(\n)";
            Regex regex = new Regex(pattern);
            string[] splitNumbers = regex.Split(numbers);

            return splitNumbers;
        }
    }
}
