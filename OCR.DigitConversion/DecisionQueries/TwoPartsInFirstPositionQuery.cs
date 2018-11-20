using OCR.Common.Extensions;
using OCR.Core.Common;

namespace OCR.DigitConversion.DecisionQueries
{
    class TwoPartsInFirstPositionQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInSecondPosition = input.CountCharactersInColumn(1);
            {
                switch (numberOfCharactersInSecondPosition)
                {
                    case 2:
                        result = Digits.Zero;
                        break;
                    case 3:
                        result = Evaluate(new TwoPartsInFirstTwoPartsInSecondQuery(),input);
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