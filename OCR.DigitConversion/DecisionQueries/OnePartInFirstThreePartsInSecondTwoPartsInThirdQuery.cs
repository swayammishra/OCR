using OCR.Common.Extensions;
using OCR.Core.Common;

namespace OCR.DigitConversion.DecisionQueries
{
    class OnePartInFirstThreePartsInSecondTwoPartsInThirdQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            bool isPartOnThirdColumnThirdRow = input.IsPositionHavingDigitPart(2, 2);
            char result = isPartOnThirdColumnThirdRow ? Digits.Five : Digits.Two;
            return result;
        }
    }
}