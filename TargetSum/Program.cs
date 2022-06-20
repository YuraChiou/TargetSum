using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string description = "\nType an array of integers nums and an integer target then press Enter."
                                + "Type ';' to end the array:\n";

            try
            {
                List<int> data = new List<int>();
                int target = 0;
                string input = null;

                do
                {
                    Console.WriteLine(description);

                    input = Console.ReadLine();

                    string[] inputArray = input.Split(";");

                    if (inputArray.Length == 2)
                    {
                        data = inputArray[0].Split(',')
                            ?.Select(x =>
                            {
                                int.TryParse(x, out int interge);
                                return interge;
                            })?.ToList();

                        int.TryParse(inputArray[1], out target);

                        Service _service = new Service();

                        _service.TargetSum(data, target);
                    }
                } while (string.IsNullOrWhiteSpace(input) || !input.Contains(';'));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0}.", ex.Message);
                Console.WriteLine(description);
            }
        }
    }
}
