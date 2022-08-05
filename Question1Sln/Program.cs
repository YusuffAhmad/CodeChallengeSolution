using System;
using System.Collections.Generic;
using System.Collections;



namespace QUESTION1SLN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testCase = {2, 2, 4, 7};
            var answer = CutTheSticks(testCase);
            foreach (var item in answer)
            {
                Console.Write(item);
            }
        }
        static List<int> CutTheSticks(int[] sticks)
        {
            int staticIndex = 1;
            List<int> result = new List<int>();
            List<int> workingList = new List<int>();
            result.Add(sticks.Length);
            Array.Sort(sticks);
            workingList = sticks.ToList();
            for(int i = 0; i < workingList.Count; i++)
            {
                for(int j = 0; j < workingList.Count-1; j++)
                {
                    if (workingList.Count >1)
                    {
                        workingList[j+1] -= workingList[staticIndex];
                    }
                }
                workingList.Remove(workingList[staticIndex]);
                for (int f = 0; f < workingList.Count-1; f++)
                {
                    if (workingList[f] == workingList[f+1])
                    {
                        workingList.Remove(workingList[f]);
                    }
                    break;
                }
                result.Add(workingList.Count);
            }
            return result;
        }
    }
}

