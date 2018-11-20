using System.Linq;
using static OCR.Core.Common.CommonReference;

namespace OCR.InputValidation.Strategies
{
    /// <summary>
    /// Validates if all characters in the line is allowed.
    /// </summary>
    public abstract class CharacterValidationBase : IValidationStrategy
    {
        public virtual bool ValidateInput(char[] characterLine)
        {
            bool isCharacterLineValid = characterLine.All(character => AllowedCharacters.Contains(character));
            return isCharacterLineValid;
        }
    }
}
