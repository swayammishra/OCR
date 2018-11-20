using System;
using System.Collections.Generic;
using System.IO;

namespace OCR.InputScanning
{
    public  static class TextFileScanner 
    {
        /// <summary>
        /// Scans the digit lines from a stream reader.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static IList<char[][]> Scan(string filePath)
        {
            IList<char[][]> digitLines = new List<char[][]>();
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader streamReader = new StreamReader(filePath))
                    {
                        digitLines = Scan(streamReader);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.Message);
            }
            return digitLines;
        }

        /// <summary>
        /// Scans the digit lines from a stream reader.
        /// </summary>
        /// <param name="streamReader"></param>
        /// <returns>list of digit lines</returns>
        private static IList<char[][]> Scan(StreamReader streamReader)
        {
            var digitLines = new List<char[][]>();
            try
            {
                while (streamReader.Peek() >= 0)
                {
                    char[][] digitLine = GetDigitLine(streamReader);
                    digitLines.Add(digitLine);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error in reading the input text stream \n{0}", e.Message);
            }
            return digitLines;
        }

        private static char[][] GetDigitLine(StreamReader streamReader)
        {
            char[][] digitLine = new char[3][];
            for (var index = 0; index < digitLine.Length; index++)
            {
                string characterLine = streamReader.ReadLine();
                digitLine[index] = characterLine?.ToCharArray();
            }
            return digitLine;
        }

    }
}

