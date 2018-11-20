using System;
using System.Collections.Generic;
using OCR.DigitConversion.Core;
using OCR.DigitConversion.DigitConverters;

namespace OCR.ClientConsole
{
    public class OutputGenerator
    {
        private const string ErrorInDataLiteral = "Error in data";
        public IList<string> GenerateOutput(IList<char[][]> digitLines)
        {
            IList<string> digitOutputs = new List<string>();
            IDigitConverter digitConverter = new DigitConverter();
            foreach (var digitLine in digitLines)
            {
                bool canConvert = digitConverter.CanConvert(digitLine);
                string digitOutput = canConvert ? (digitConverter.Convert(digitLine)) : ErrorInDataLiteral;
                digitOutputs.Add(digitOutput);
            }
            return digitOutputs;
        }
        
    }
}