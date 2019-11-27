using System;
using System.Collections.Generic;
using System.Linq;
namespace StringCalculator
{
    public class Calculator
    {
        List<char> delimiters = new List<char> {',','\n'};
        public Calculator()
        { }

        public int Add(string input)
        {          
            var total = ProcessInput(input).Sum(s=>int.Parse(s));
            return total;
        }

        public string[] ProcessInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new string[] { "0" };
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