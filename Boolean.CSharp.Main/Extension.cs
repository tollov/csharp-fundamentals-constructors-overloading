﻿



using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float numOne, float numTwo)
        {
            return numOne + numTwo;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float numOne, float numTwo)
        {
            return numOne - numTwo;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string subtract(string s, char c)
        {
            return s.Replace(c.ToString(), "");
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string s, int n)
        {
            return string.Join(",", Enumerable.Repeat(s, n));
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] nums, int n)
        {
            int[] results = new int[nums.Length];
            for (int i = 0; i < results.Length; i++)
            {
                int num = int.Parse(nums[i]);
                results[i] = num * n;
            }
            return results;
        }
    }
}
