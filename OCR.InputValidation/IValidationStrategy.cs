namespace OCR.InputValidation
{
    public interface IValidationStrategy
    {
        bool ValidateInput(char[] characterLine);
    }
}
