using OCR.Common.Extensions;
using OCR.Core.Common;

namespace OCR.DigitConversion.DecisionQueries
{
    class TwoPartsInFirstTwoPartsInSecondQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInThirdPosition = input.CountCharactersInColumn(2);
            {
                switch (numberOfCharactersInThirdPosition)
                {
                    case 1:
                        result = Digits.Six;
                        break;
                    case 2:
                        result = Digits.Eight;
                        break;
                    default:
                        result = base.Evaluate(input);
                        break;
                }
            }
            return result;
        }
    }
}