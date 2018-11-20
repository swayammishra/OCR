using OCR.Core.Extensions;

namespace OCR.OutputEvaluation.Queries
{
    public class NoPartInFirstPositionQuery : DecisionQueryBase
    {
        public override char Evaluate(char[][] input)
        {
            char result;
            int numberOfCharactersInSecondColumn = input.CountCharactersInColumn(1);
            {
                switch (numberOfCharactersInSecondColumn)
                {
                    case 0:
                        result = '1';
                        break;
                    case 1:
                        result = '7';
                        break;
                    case 3:
                        result = '3';
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