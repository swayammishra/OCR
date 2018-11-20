using OCR.Common.Extensions;
using OCR.Core.Common;

namespace OCR.DigitConversion.DecisionQueries
{
    class OnePartInFirstPositionQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInSecondPosition = input.CountCharactersInColumn(1);
            {
                switch (numberOfCharactersInSecondPosition)
                {
                    case 1:
                        result = Digits.Four;
                        break;
                    case 2:
                        result = Digits.Nine;
                        break;
                    case 3:
                        result = Evaluate(new OnePartInFirstThreePartsInSecondQuery(), input);
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