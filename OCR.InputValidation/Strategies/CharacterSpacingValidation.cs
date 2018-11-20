using OCR.Core.Common;
namespace OCR.InputValidation.Strategies
{
    /// <summary>
    /// Validates if line with allowed characters have expected spacing in between.
    /// </summary>
    public class CharacterSpacingValidation : CharacterValidationBase
    {
        public override bool ValidateInput(char[] characterLine)
        {
            bool isInputValid = base.ValidateInput(characterLine);
            if (isInputValid)
            {
                isInputValid = HasRequiredSpacingCharacterInBetween(characterLine);
            }
            return isInputValid;
        }
        private static bool HasRequiredSpacingCharacterInBetween(char[] characterLine)
        {
            bool hasSpacingCharacterInBetween = false;
            if (characterLine.Length == 3)
            {
                hasSpacingCharacterInBetween = true;
            }
            else if (characterLine.Length > 3)
            {
                for (int index = 1; index <= characterLine.Length; index++)
                {
                    if (index % 4 == 0)
                    {
                        hasSpacingCharacterInBetween = (characterLine[index - 1] == DigitPartLiterals.SpaceTabLiteral);
                    }
                }
            }
            return hasSpacingCharacterInBetween;
        }
    }
}