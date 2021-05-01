namespace Triangles
{
    public class Message
    {
        public const string NumberOutOfRange = "Incorrect number input: number out of range [1..2147483647]";
        public const string NegativeNumber = "Incorrect number input: number is negative. Enter an integer in the range [1..2147483647]";
        public const string FloatNumber = "Incorrect number input: real number. Enter an integer in the range [1..2147483647]";
        public const string LetterCharacters = "Incorrect number input: input of alphabetic characters. Enter an integer in the range [1..2147483647]";
        public const string EmptyString = "Incorrect number input: empty string input. Enter an integer in the range [1..2147483647]";
        public const string TriangleNotExist = "Each side of the triangle must be less than the sum of the other two";

        public const string EquilateralTriangle = "Equilateral triangle";
        public const string IsoscelesTriangle = "Isosceles triangle";
        public const string UsualTriangle = "Usual triangle";
    }
}