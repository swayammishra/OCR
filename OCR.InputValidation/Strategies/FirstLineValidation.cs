using OCR.Core.Common;

namespace OCR.InputValidation.Strategies
{
    /// <summary>
    /// Validates the first character line
    /// </summary>
    public class FirstLineValidation : CharacterSpacingValidation
    {
        public override bool ValidateInput(char[] characterLine)
        {
            bool isInputValid = base.ValidateInput(characterLine);
            if (isInputValid)
            {
                isInputValid = IsFirstCharacterLineValid(characterLine);
            }
            return isInputValid;
        }
        private static bool IsFirstCharacterLineValid(char[] characterLine)
        {
            char firstCharacterOfLine = characterLine[0];
            char lastCharacterOfLine = characterLine[characterLine.Length - 1];
            bool isFirstCharacterLineValid = (firstCharacterOfLine == DigitPartLiterals.SpaceTabLiteral) && (lastCharacterOfLine == DigitPartLiterals.SpaceTabLiteral);
            if (isFirstCharacterLineValid)
            {
                for (var index = 1; index < characterLine.Length - 1; index++)
                {
                    char character = characterLine[index];
                    isFirstCharacterLineValid = (character == DigitPartLiterals.SpaceTabLiteral) || (character == DigitPartLiterals.HorizontalDigitPartLiteral);
                }
            }
            return isFirstCharacterLineValid;
        }
    }
}