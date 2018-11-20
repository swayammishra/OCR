using System;
using OCR.Core;
using OCR.DigitConversion.Core;
using OCR.DigitConversion.Core.Helpers;
using OCR.DigitConversion.Evaluators;
using OCR.InputValidation;
using OCR.InputValidation.Strategies;
using System.Collections.Generic;
namespace OCR.DigitConversion.DigitConverters
{
    public class DigitConverter : IDigitConverter
    {
        public DigitConverter()
        {
            _outputEvaluator = new OutputEvaluator();
        }
       
        private readonly IOutputEvaluator _outputEvaluator;
        public bool CanConvert(char[][] digitLine)
        {
            bool canConvert = false;
            for (int index = 0; index < digitLine.Length; index++)
            {
                char[] characterLine = digitLine[index];
                IValidationStrategy inputValidationStrategy = (index == 0) ? new FirstLineValidation() : new CharacterSpacingValidation();
                canConvert = inputValidationStrategy.ValidateInput(characterLine);
            }
            return canConvert;
        }
        public string Convert(char[][] digitLine)
        {
            string output;
            try
            {
                int digitCount = DigitConversionHelper.GetDigitCount(digitLine);
                IList<char[][]> digits = DigitConversionHelper.GetDigitsFromDigitLine(digitLine, digitCount);
                output = DigitConversionHelper.GetOutputString(_outputEvaluator, digits);
            }
            catch (Exception )
            {
                output = "Error in data";
            }
            return output;
        }
    }
}
