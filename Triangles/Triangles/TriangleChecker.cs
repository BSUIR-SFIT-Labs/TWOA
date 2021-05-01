using System.Text.RegularExpressions;
using static System.Int64;

namespace Triangles
{
    public class TriangleChecker
    {
        private const string NumberRegex = @"^-?\d+$";

        private readonly string _firstSide;
        private readonly string _secondSide;
        private readonly string _thirdSide;

        public TriangleChecker(string firstSide, string secondSide, string thirdSide)
        {
            _firstSide = firstSide.Trim();
            _secondSide = secondSide.Trim();
            _thirdSide = thirdSide.Trim();
        }

        public string CheckTriangle()
        {
            if (IsEmptyString(_firstSide) || IsEmptyString(_secondSide) || IsEmptyString(_thirdSide))
                return Message.EmptyString;

            if (IsFloatNumber(_firstSide) || IsFloatNumber(_secondSide) || IsFloatNumber(_thirdSide))
                return Message.FloatNumber;

            if (IsStringContainsLetters(_firstSide) || IsStringContainsLetters(_secondSide)
                                                    || IsStringContainsLetters(_thirdSide))
                return Message.LetterCharacters;

            _ = TryParse(_firstSide, out long longFirstSide);
            _ = TryParse(_secondSide, out long longSecondSide);
            _ = TryParse(_thirdSide, out long longThirdSide);

            if (IsNumberNegative(longFirstSide) || IsNumberNegative(longSecondSide) || IsNumberNegative(longThirdSide))
                return Message.NegativeNumber;

            if (IsNumberOutOfRange(longFirstSide) || IsNumberOutOfRange(longSecondSide)
                                                  || IsNumberOutOfRange(longThirdSide))
                return Message.NumberOutOfRange;

            int firstSide = (int) longFirstSide;
            int secondSide = (int) longSecondSide;
            int thirdSide = (int) longThirdSide;

            if (IsTriangleNotExists(firstSide, secondSide, thirdSide)) return Message.TriangleNotExist;

            if (IsEquilateralTriangle(firstSide, secondSide, thirdSide)) return Message.EquilateralTriangle;

            if (IsIsoscelesTriangle(firstSide, secondSide, thirdSide)) return Message.IsoscelesTriangle;

            return Message.UsualTriangle;
        }


        private static bool IsEmptyString(string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        private static bool IsFloatNumber(string str)
        {
            return str.Contains('.');
        }

        private static bool IsStringContainsLetters(string str)
        {
            return !Regex.IsMatch(str, NumberRegex);
        }

        private static bool IsNumberNegative(long number)
        {
            return number < 0;
        }

        private static bool IsNumberOutOfRange(long number)
        {
            return number < 1 || number > int.MaxValue;
        }

        private static bool IsTriangleNotExists(long firstSide, long secondSide, long thirdSide)
        {
            return !(firstSide + secondSide > thirdSide
                     && firstSide + thirdSide > secondSide
                     && secondSide + thirdSide > firstSide);
        }

        private static bool IsEquilateralTriangle(long firstSide, long secondSide, long thirdSide)
        {
            return firstSide == secondSide && firstSide == thirdSide;
        }

        private static bool IsIsoscelesTriangle(long firstSide, long secondSide, long thirdSide)
        {
            return firstSide == secondSide
                   || firstSide == thirdSide
                   || secondSide == thirdSide;
        }
    }
}