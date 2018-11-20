namespace OCR.OutputEvaluation.Core
{
    public interface IDecision
    {
        IDecision Decision { get; set; }
        char Evaluate(char[][] input);
    }
}