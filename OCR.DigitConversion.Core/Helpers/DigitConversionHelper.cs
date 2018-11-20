using System;
using System.Collections.Generic;
using System.Text;
using OCR.Common;

namespace OCR.DigitConversion.Core.Helpers
{
    public static class DigitConversionHelper
    {
        /// <summary>
        /// Gets the output string 
        /// </summary>
        /// <param name="digits"></param>
        /// <param name="outputEvaluator"></param>
        /// <returns></returns>
        public static string GetOutputString(IOutputEvaluator outputEvaluator , IList<char[][]> digits)
        {
            string output = string.Empty;
            StringBuilder outputStringBuilder = new StringBuilder();
            foreach (char[][] digit in digits)
            {
                bool isInputProper = outputEvaluator.VerifyInput(digit);
                if (!isInputProper)
                {
                    output = "Error in data.";
                    break;
                }
                char evaluatedDigitChar = outputEvaluator.Evaluate(digit);
                outputStringBuilder.Append(evaluatedDigitChar);
                output = outputStringBuilder.ToString();
            }
            return output;
        }
     
        public static IList<char[][]> GetDigitsFromDigitLine(char[][] characterLines, int digitCount)
        {
            // initialize a list of char jagged array for saving 
            var outputDigits = InitializeOutputDigits(digitCount);
            for (var lineIndex = 0; lineIndex < characterLines.Length; lineIndex++)
            { 
               char[] characterLine = characterLines[lineIndex];
                // loop through each character line
                for (int digitIndex = 0; digitIndex < outputDigits.Count; digitIndex++)
                {
                    var outputDigit = outputDigits[digitIndex];
                    outputDigit[lineIndex][0] = characterLine[4 * digitIndex];
                    outputDigit[lineIndex][1] = characterLine[(4 * digitIndex) + 1];
                    outputDigit[lineIndex][2] = characterLine[(4 * digitIndex) + 2];
                }
            }
            return outputDigits;
        }
        private static IList<char[][]> InitializeOutputDigits(int digitCount)
        {
            var outputDigits = new List<char[][]>();
            for (int digitIndex = 0; digitIndex < digitCount; digitIndex++)
            {
                outputDigits.Add(CommonHelper.CreateJaggedArray<char>(3, 3));
            }
            return outputDigits;
        }

        public static int GetDigitCount(char[][] characterLines)
        {
            int digitCount = 0;
            if (characterLines[0].Length != characterLines[1].Length || characterLines[0].Length != characterLines[2].Length)
            {
                throw new Exception("wrong character length incomplete digits.");
            }
            char[] firstCharacterLine = characterLines[0];
            // last element ends with space
            if (firstCharacterLine.Length % 4 == 0)
            {
                digitCount = firstCharacterLine.Length / 4;
            }
            // last element ends with character
            else if ((firstCharacterLine.Length + 1) % 4 == 0)
            {
                digitCount = (firstCharacterLine.Length + 1) / 4;
            }
            else
            {
                throw new Exception("wrong character length incomplete digits.");
            }
            return digitCount;
        }
    }
}
