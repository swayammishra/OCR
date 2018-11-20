using OCR.Common.Extensions;
using OCR.Core.Common;

namespace OCR.DigitConversion.DecisionQueries
{
    class OnePartInFirstThreePartsInSecondQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            int isTwoPartsInThirdColumn = input.CountCharactersInColumn(2);
            char result;
            switch (isTwoPartsInThirdColumn)
            {
                case 1:
                    result = Evaluate(new OnePartInFirstThreePartsInSecondTwoPartsInThirdQuery(),input);
                    break;
                case 2:
                    result = Digits.Nine;
                    break;
                default:
                    result = base.Evaluate(input);
                    break;
            }
            return result;
        }
    }
}