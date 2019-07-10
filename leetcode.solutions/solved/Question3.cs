using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public static class Question3
    {
        public static int Solve(string s) 
        {
            int bestRunLength = 0;
            //string currentRun = "";
            int currentRunLen = 0;

            var lastOccuranceIdxs = new Dictionary<char, int>();
            var currentRunStartIdx = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                var c = s[i];

                if (lastOccuranceIdxs.TryGetValue(c, out int idx) && idx >= currentRunStartIdx)
                {
                    if (currentRunLen > bestRunLength)
                    {
                        bestRunLength = currentRunLen;
                    }
                    
                    //currentRun = currentRun.Substring(idx - currentRunStartIdx + 1) + c;

                    // Expanded from: currentRunLen = currentRunLen - (idx - currentRunStartIdx)
                    currentRunLen = currentRunLen - idx + currentRunStartIdx;

                    currentRunStartIdx = idx + 1;                  
                }
                else
                {
                    //currentRun = currentRun + c;
                    currentRunLen += 1;
                }

                lastOccuranceIdxs[c] = i;
            }
            
            if (currentRunLen > bestRunLength)
            {
                bestRunLength = currentRunLen;
            }

            return bestRunLength;
        }

        // Store only current run
        // public static int Solve(string s) 
        // {
        //     int bestRunLength = 0;
        //     string currentRun = "";

        //     for (int i = 0; i < s.Length; ++i)
        //     {
        //         var c = s[i];

        //         var idx = currentRun.IndexOf(c);

        //         if (idx > -1)
        //         {
        //             if (currentRun.Length > bestRunLength)
        //             {
        //                 bestRunLength = currentRun.Length;
        //             }

        //             currentRun = currentRun.Substring(idx + 1) + c;
        //         }
        //         else
        //         {
        //             currentRun = currentRun + c;
        //         }
        //     }

        //     if (currentRun.Length > bestRunLength)
        //     {
        //         bestRunLength = currentRun.Length;
        //     }

        //     return bestRunLength;
        // }

        // Cache all runs
        // public static int Solve(string s) 
        // {
        //     string[] runTo = new string[s.Length + 1];
        //     runTo[0] = "";

        //     for (int i = 0; i < s.Length; ++i)
        //     {
        //         var c = s[i];

        //         var prev = runTo[i];
        //         var idx = prev.IndexOf(c);

        //         string next;
        //         if (idx > -1)
        //         {
        //             next = prev.Substring(idx + 1) + c;
        //         }
        //         else
        //         {
        //             next = prev + c;
        //         }

        //         runTo[i + 1] = next;
        //     }

        //     return runTo.Max(st => st.Length);
        // }

        // Brute Force
        // public static int Solve(string s) 
        // {
        //     int best = 0;

        //     for (int i = 0; i < s.Length; ++i)
        //     {
        //         var seen = new HashSet<char>();

        //         int j = 0;
        //         while (i + j < s.Length && !seen.Contains(s[i + j]))
        //         {
        //             seen.Add(s[i + j]);
        //             ++j;
        //         }

        //         if (j > best)
        //         {
        //             best = j;
        //         }
        //     }

        //     return best;
        // }

        // public static int Solve(string s) 
        // {
        //     var prevIdxs = new System.Collections.Generic.Dictionary<char, int>();
        //     int[] prevOccurances = new int[s.Length];
        //     int[] runLengths = new int[s.Length];

        //     for (int i = 0; i < s.Length; ++i)
        //     {
        //         if (!prevIdxs.TryGetValue(s[i], out int prevIdx))
        //         {
        //             prevIdx = -1;
        //         }

        //         prevOccurances[i] = prevIdx;

        //         prevIdxs[s[i]] = i;
        //     }

        //     Utils.Print(s);
        //     Utils.Print(prevOccurances);

        //     int bestRun = 1;
        //     runLengths[0] = 1;

        //     for (int i = 1; i < s.Length; ++i)
        //     {              
        //         if (prevOccurances[i] > -1)
        //         {
        //             if (runLengths[i - 1] > bestRun)
        //             {
        //                 bestRun = runLengths[i - 1];
        //             }

        //             runLengths[i] = runLengths[i - 1] - runLengths[prevOccurances[i]] + 1;
        //         }
        //         else
        //         {
        //             runLengths[i] = runLengths[i - 1] + 1;                   
        //         }
        //     }

        //     Utils.Print(runLengths);


        //     if (runLengths[s.Length - 1] > bestRun)
        //     {
        //         bestRun = runLengths[s.Length - 1];
        //     }

        //     return bestRun;
        // }

        // public static int Solve(string s) 
        // {
        //     int[] runLengths = new int[s.Length];
        //     int[] prevIdxs = new int[26];

        //     for (int i = 0; i < 26; ++i)
        //     {
        //         prevIdxs[i] = -1;
        //     }

        //     for (int i = 0; i < s.Length; ++i)
        //     {
        //         int c = (int) (s[i] - 'a');

        //         int prevIdx = prevIdxs[c];
        //         if (prevIdx > -1)
        //         {
        //             int runLength = i - prevIdx;
        //             runLengths[prevIdx] = runLength;
        //         }

        //         prevIdxs[c] = i;
        //     }

        //     for (int i = 0; i < 26; ++i)
        //     {
        //         int prevIdx = prevIdxs[i];
        //         if (prevIdx > -1)
        //         {
        //             int runLength = s.Length - prevIdx;
        //             runLengths[prevIdx] = runLength;
        //         }
        //     }

        //     Utils.Print(s);
        //     Utils.Print(runLengths);

        //     int bestRunLength = -1;

        //     int currRunLength = runLengths[0];
        //     int currRunStart = 0;

        //     for (int i = 1; i < s.Length; ++i)
        //     {
        //         int remainingLength = currRunLength - (i - currRunStart);

        //         if (runLengths[i] + 1 < remainingLength) // Run is invalid
        //         {
        //             System.Console.WriteLine($"Run invalid at i = {i}");

        //             currRunStart = i;
        //             currRunLength = runLengths[i];
        //         }
        //         else if (remainingLength == 0) // Run complete
        //         {
        //             System.Console.WriteLine($"Run complete at i = {i}");

        //             if (bestRunLength < currRunLength)
        //             {
        //                 bestRunLength = currRunLength;
        //             }

        //             currRunStart = i;
        //             currRunLength = runLengths[i];
        //         }
        //     }

        //     if (s.Length - currRunStart == currRunLength)
        //     {
        //         if (bestRunLength < currRunLength)
        //         {
        //             bestRunLength = currRunLength;
        //         }
        //     }

        //     return bestRunLength;
        // }
    }
}