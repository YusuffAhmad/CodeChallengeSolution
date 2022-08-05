using System;
using System.Collections.Generic;
using System.Collections;



namespace QUESTION2SLN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testCase = {1, 2, 3};
            Console.WriteLine(WaterContainer(testCase));
            
        }
        static int WaterContainer(int[] arr)
        {
            int result = 0;
            List<int> workingList = new List<int>();
            Array.Sort(arr);
            workingList = arr.ToList();
            result = workingList[^1] * workingList[^1] -1;
            return result;
        }
    }
}

