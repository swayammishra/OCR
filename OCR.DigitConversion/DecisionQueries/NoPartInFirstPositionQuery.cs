using OCR.Common.Extensions;
using OCR.Core.Common;

namespace OCR.DigitConversion.DecisionQueries
{
    class NoPartInFirstPositionQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInSecondColumn = input.CountCharactersInColumn(1);
            {
                switch (numberOfCharactersInSecondColumn)
                {
                    case 0:
                        result = Digits.One;
                        break;
                    case 1:
                        result = Digits.Seven;
                        break;
                    case 3:
                        result = Digits.Three;
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