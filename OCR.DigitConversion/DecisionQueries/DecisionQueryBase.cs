using OCR.OutputEvaluation.Core;
namespace OCR.DigitConversion.DecisionQueries
{
    public abstract class DecisionQueryBase : IDecision
    {
        public IDecision Decision { get; set; }

        public virtual char Evaluate(char[][] input)
        {
            // base logic

            return ' ';
        }

        protected char Evaluate(IDecision decision, char[][] input)
        {
            return decision.Evaluate(input);
        }
    }
}