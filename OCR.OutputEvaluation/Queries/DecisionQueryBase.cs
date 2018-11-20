using OCR.OutputEvaluation.Core;

namespace OCR.OutputEvaluation.Queries
{
    public abstract class DecisionQueryBase : IDecision
    {
        public virtual char Evaluate(char[][] input)
        {
            // base logic

            return ' ';
        }
    }
}