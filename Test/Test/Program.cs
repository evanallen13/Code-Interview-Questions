using System;
using System.Collections;
using System.IO;
using Test.Enum;
using Test.Model;

namespace Test
{
    class Program
    {
        static string path = "C:\\Users\\evana\\Desktop\\LeetCode\\README.md";
        static void Main(string[] args)
        {
            Queue queue = CreateQueue();

            WriteToReadMe(queue);
        }

        static void WriteToReadMe(Queue queue)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);

                // Title
                sw.WriteLine("# Leet Code Examples");
                sw.WriteLine(" ");
                //Write a second line of text
                //sw.WriteLine("| # | Name | Language | Difficulty|");
                //while(queue.Count > 0)
                //{
                //    TableRow row = (TableRow)queue.Dequeue();
                //    sw.WriteLine($"| 1 | Two Sums | [C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0001_TwoSums.cs)| [![Generic badge](https://img.shields.io/badge/-Easy-brightgreen)](https://shields.io/)");
                //    sw.WriteLine("");
                //}

                sw.WriteLine("Attempt | #1 | #2 | #3 | #4 | #5 | #6 | #7 | #8 | #9 | #10 | #11");
                sw.WriteLine("-- - | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | ---");
                sw.WriteLine("Seconds | 301 | 283 | 290 | 286 | 289 | 285 | 287 | 287 | 272 | 276 | 269");
 

                 sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static Queue CreateQueue()
        {
            Queue queue = new Queue();

            TableRow row1 = new TableRow();
            row1.Number = 1;
            row1.Name = "Two Sums";
            row1.Language = Language.CSharp;
            row1.Difficulty = Difficulty.Easy;
            row1.CSharpUrl = "https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0001_TwoSums.cs";

            TableRow row2 = new TableRow();
            row2.Number = 2;
            row2.Name = "Add Two Numbers";
            row2.Language = Language.CSharp;
            row2.Difficulty = Difficulty.Medium;
            row2.CSharpUrl = "https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0002_AddTwoNumbers.cs";

            queue.Enqueue(row1);
            queue.Enqueue(row2);

            return queue;
        }
    }
}
//# Leet Code Examples

//| # | Name | Language | Difficulty
//| --- | --- | --- | --- |
//| 1 | Two Sums | [C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0001_TwoSums.cs)| [![Generic badge](https://img.shields.io/badge/-Easy-brightgreen)](https://shields.io/) |
//| 2 | Add Two Numbers |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0002_AddTwoNumbers.cs) | [![Generic badge](https://img.shields.io/badge/-Medium-yellow)](https://shields.io/) |
//| 7 | Reverse Integer |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0007_ReverseInteger.cs) | [![Generic badge](https://img.shields.io/badge/EASY-<COLOR>.svg)](https://shields.io/) |
//| 9 | Is Palidrone |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/009_IsPalidrome.cs) | [![Generic badge](https://img.shields.io/badge/EASY-<COLOR>.svg)](https://shields.io/) |
//| 13 | Roman To Integer |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/013_RomanToInt.cs) | [![Generic badge](https://img.shields.io/badge/EASY-<COLOR>.svg)](https://shields.io/) |
//| 14 | Longest Common Prefix |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/014_LongestCommonPrefix.cs) | [![Generic badge](https://img.shields.io/badge/EASY-<COLOR>.svg)](https://shields.io/) |
//| 20 | Valid Paretheses |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/020_ValidParetheses.cs) | [![Generic badge](https://img.shields.io/badge/EASY-<COLOR>.svg)](https://shields.io/) |
//| 100 | Test |[C#](https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/020_ValidParetheses.cs) | [![Generic badge](https://img.shields.io/badge/-Hard-red)](https://shields.io/) |