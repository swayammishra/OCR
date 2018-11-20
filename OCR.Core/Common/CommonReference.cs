using System.Collections.Generic;

namespace OCR.Core.Common
{
    public static class CommonReference
    {
        public static char[] AllowedCharacters { get; } =
        {
            DigitPartLiterals.SpaceTabLiteral,
            DigitPartLiterals.VerticalDigitPartLiteral,
            DigitPartLiterals.HorizontalDigitPartLiteral
        };
   }
}