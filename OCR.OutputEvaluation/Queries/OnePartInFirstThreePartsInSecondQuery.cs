using OCR.Core.Extensions;

namespace OCR.OutputEvaluation.Queries
{
    public class OnePartInFirstThreePartsInSecondQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            bool isPartOnThirdColumnThirdRow = input.IsPositionHavingDigitPart(2,2);
            var result = isPartOnThirdColumnThirdRow ? '2' : '5';
            return result;
        }
    }
}