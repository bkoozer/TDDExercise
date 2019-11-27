using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class Calculator
    {
        List<char> delimiters = new List<char> {',','\n'};
        public Calculator()
        {
        }

        public int Add(string input)
        {
            if (String.IsNullOrEmpty(input))
                return 0;           
            int total = 0;
            var nums = ProcessInput(input);
            foreach (var num in nums)
            {
                total += int.Parse(num);
            }
            return total;
        }

        public string[] ProcessInput(string input)
        {
            if (input.StartsWith("//"))
            {
                var newDelimiter = input.Split('\n')[0].Replace("//", "").ToCharArray()[0];
                delimiters.Add(newDelimiter);
                input = input.Replace("//" + newDelimiter + "\n", "");
            }
            var nums = input.Split(delimiters.ToArray());
            return nums;
        }
    }
}