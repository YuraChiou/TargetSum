using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetSum
{
    public class Service
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="data">An array of integers nums</param>
        /// <param name="target">An integer target</param>
        /// <returns>Return indices of the two numbers such that they add up to target.</returns>
        public void TargetSum(List<int> data, int target)
        {
            try
            {

                // Input: List<int> data = new List<int> { 1, 2, 3, 4, 5, 6 };
                // Target: int target = 10;
                // Output: [3, 5]
                Console.WriteLine($"Input: { string.Join(", ", data) }");
                Console.WriteLine($"Target: { target }");

                Dictionary<int, int> output = new Dictionary<int, int>();
                Dictionary<int, int> dataDictionary = data.ToDictionary(x => x);

                for (int i = 0; i < data.Count(); i++)
                {
                    int augend = target - data[i];

                    if (dataDictionary.ContainsValue(augend))
                    {
                        int indexOfAugend = Array.IndexOf(dataDictionary.Values.ToArray(), augend);
                        output.Add(i, indexOfAugend);

                        break;
                    }
                }

                Console.WriteLine($"Output: [{ output.First().Key }, { output.First().Value }]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0}.", ex.Message);
            }
        }
    }
}
