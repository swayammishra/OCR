using System;
using System.Collections.Generic;
using OCR.InputScanning;
using static System.Console;

namespace OCR.ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = Console.ReadLine();
            IList<char[][]> digitLines = TextFileScanner.Scan(inputFilePath); //@"c:\Sample\MyTest.txt");
            OutputGenerator outputGenerator = new OutputGenerator();
            IList<string> digitOutputs = outputGenerator.GenerateOutput(digitLines); 
            PrintDigitOutputs(digitOutputs);
            ReadLine();
        }
        private static void PrintDigitOutputs(IList<string> digitOutputs)
        {
            foreach (var digitOutput in digitOutputs)
            {
                WriteLine(digitOutput);
            }
        }
    }
}
