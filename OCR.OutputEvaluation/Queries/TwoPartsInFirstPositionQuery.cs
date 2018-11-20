using OCR.Core.Extensions;

namespace OCR.OutputEvaluation.Queries
{
    public class TwoPartsInFirstPositionQuery : DecisionQueryBase
    {
        private readonly TwoPartsInFirstTwoPartsInSecondQuery _twoPartsInFirstTwoPartsInSecondQuery;
        public TwoPartsInFirstPositionQuery()
        {
            _twoPartsInFirstTwoPartsInSecondQuery = new TwoPartsInFirstTwoPartsInSecondQuery();
        }
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInSecondPosition = input.CountCharactersInColumn(1);
            {
                switch (numberOfCharactersInSecondPosition)
                {
                    case 2:
                        result = '0';
                        break;
                    case 3:
                        result = _twoPartsInFirstTwoPartsInSecondQuery.Evaluate(input);
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