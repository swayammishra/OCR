using OCR.Core.Extensions;

namespace OCR.OutputEvaluation.Queries
{
    public class OnePartInFirstPositionQuery : DecisionQueryBase
    {
        private readonly OnePartInFirstThreePartsInSecondQuery _onePartInFirstThreePartsInSecondQuery;
        public OnePartInFirstPositionQuery()
        {
            _onePartInFirstThreePartsInSecondQuery = new OnePartInFirstThreePartsInSecondQuery();
        }
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInSecondPosition = input.CountCharactersInColumn(1);
            {
                switch (numberOfCharactersInSecondPosition)
                {
                    case 1:
                        result = '4' ;
                        break;
                    case 2:
                        result = '9';
                        break;
                    case 3:
                        result = _onePartInFirstThreePartsInSecondQuery.Evaluate(input);
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