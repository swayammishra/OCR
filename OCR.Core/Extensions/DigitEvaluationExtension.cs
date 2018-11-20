using System.Linq;
using OCR.Core.Common;

namespace OCR.Common.Extensions
{
    public static class DigitEvaluationExtension
    {
        public static short CountLineDigitPart(this char[][] digit, short lineIndex)
        {
            var linePartsCount = (short) digit[lineIndex].Count(x => x != DigitPartLiterals.SpaceTabLiteral);
            return linePartsCount;
        }


        public static bool IsDigitNotEmpty(this char[][] digit)
        {
            bool isDigitNotEmpty = false;
            foreach (char[] characterLine in digit)
            {
                isDigitNotEmpty = characterLine.Any(character => character != DigitPartLiterals.SpaceTabLiteral);
                if (isDigitNotEmpty)
                {
                    break;
                }
            }

            return isDigitNotEmpty;
        }

        public static bool IsPositionHavingDigitPart(this char[][] digit, short lineIndex, short characterIndex)
        {
            return digit[lineIndex][characterIndex] != DigitPartLiterals.SpaceTabLiteral;
        }

        public static int IsLineHavingDigitPart(this char[][] digit, short lineIndex)
        {
            return digit[lineIndex].Count(character => character != DigitPartLiterals.SpaceTabLiteral);
        }

        public static int CountCharactersInColumn(this char[][] digit, short characterIndex)
        {
            int count = 0;
            for (var index = 0; index < digit.Length; index++)
            {
                char[] charLine = digit[index];
                if (charLine[characterIndex] != DigitPartLiterals.SpaceTabLiteral)
                {
                    count++;
                }
            }

            return count;
        }

        public static bool AreCharactersAllSame(this char[][] digit, short lineNumber)
        {
            if (digit[lineNumber][0] == digit[lineNumber][1] && digit[lineNumber][0] == digit[lineNumber][2])
            {
                return true;
            }

            return false;
        }
    }


}
