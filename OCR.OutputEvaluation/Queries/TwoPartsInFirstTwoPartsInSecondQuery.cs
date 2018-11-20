using OCR.Core.Extensions;

namespace OCR.OutputEvaluation.Queries
{
    public class TwoPartsInFirstTwoPartsInSecondQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInThirdPosition = input.CountCharactersInColumn(2);
            {
                switch (numberOfCharactersInThirdPosition)
                {
                    case 2:
                        result = '6';
                        break;
                    case 3:
                        result = '8';
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