using System;
using OCR.OutputEvaluation.Core;

namespace OCR.DigitConversion.Core
{
    public interface IOutputEvaluator : IDecision
    {
        Func<char[][], bool> VerifyInput { get; }
    }
}