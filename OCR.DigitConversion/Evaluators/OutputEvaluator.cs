using System;
using OCR.Common.Extensions;
using OCR.DigitConversion.Core;
using OCR.DigitConversion.DecisionQueries;

namespace OCR.DigitConversion.Evaluators
{
    public class OutputEvaluator : DecisionQueryBase,IOutputEvaluator 
    {
        public OutputEvaluator()
        {
            VerifyInput = IsInputHasParts;
        }
        public Func<char[][],bool> VerifyInput { get; }
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInFirstPosition = input.CountCharactersInColumn(0);
            switch (numberOfCharactersInFirstPosition)
            {
                case 0:
                {
                    result = Evaluate(new NoPartInFirstPositionQuery(), input);
                    break;
                }
                case 1:
                {
                     result = Evaluate(new OnePartInFirstPositionQuery(), input);
                     break;
                 }
                case 2:
                {
                    result = Evaluate(new TwoPartsInFirstPositionQuery(),input);
                    break;
                }
                default:
                    result = base.Evaluate(input);
                    break;
            }
            return result;
        }
        private bool IsInputHasParts(char[][] input)
        {
            return input.IsDigitNotEmpty();
        }
    }
}