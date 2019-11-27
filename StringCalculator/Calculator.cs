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
            if (input.StartsWith("//"))
            {
                var newdelimiter = input.Split('\n')[0].Replace("//", "").ToCharArray();
                delimiters.Add(newdelimiter[0]);
                input = input.Replace("//" + newdelimiter[0] + "\n", "");
            }
            var nums = input.Split(delimiters.ToArray());
            int total = 0;
            foreach (var num in nums)
            {
                total += int.Parse(num);
            }
            return total;
        }
    }
}