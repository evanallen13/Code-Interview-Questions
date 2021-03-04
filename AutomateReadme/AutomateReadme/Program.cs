using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CreateReadMe.Enum;
using CreateReadMe.Model;
using ClosedXML.Excel;

namespace AutomateReadme
{
    class Program
    {
        static string ReadMePath = "C:\\Users\\evaall\\Desktop\\CodeQuestions\\README.md";
        static string ExcelPath = "C:\\Users\\evaall\\Desktop\\CodeQuestions\\AutomateReadme\\LeetCode.xlsx";
        static void Main(string[] args)
        {
            Queue queue = CreateQueue();
            WriteToReadMe(queue);
        }

        static void WriteToReadMe(Queue queue)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ReadMePath);

                // Title
                sw.WriteLine("# Leet Code Examples");
                sw.WriteLine(" ");
                // THead
                sw.WriteLine("| # | Name  | Language | Difficulty |");
                sw.WriteLine(" :---        | :---   |:----:   | :---  |");

                while (queue.Count > 0)
                {
                    TableRow row = (TableRow)queue.Dequeue();
                    string languagesStr = ConvertLanguages(row);
                    sw.WriteLine($"| {row.Number} |    {row.Name}  | {languagesStr}  | {row.DifficultyBadge()} |");
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static string ConvertLanguages(TableRow row)
        {
            string result = String.Empty;
            foreach (Language lang in row.Languages)
            {
                switch (lang)
                {
                    case Language.CSharp:
                        result += $"[C#]({row.CSharpUrl})";
                        break;

                    default:
                        result += $"[C#]({row.CSharpUrl})";
                        break;
                }
            }
            return result;
        }

        static Queue CreateQueue()
        {
            Queue queue = new Queue();

            var workbook = new XLWorkbook(ExcelPath);
            var ws1 = workbook.Worksheet(1);
            int i = 0;

            foreach (IXLRow row in ws1.Rows())
            {
                if (i != 0)
                {
                    TableRow tr = new TableRow();
                    tr.Number = row.Cell(1).GetString();
                    tr.Name = row.Cell(2).GetString().Trim();
                    tr.Languages.Add(Language.CSharp);
                    tr.Difficulty = row.Cell(8).GetString();
                    tr.CSharpUrl = "https://github.com/evanallen13/Code-Interview-Questions/blob/main/C%23/LeetCode/LeetCode/0002_AddTwoNumbers.cs";

                    queue.Enqueue(tr);
                }
                i++;
            }

            return queue;
        }
    }
}
  