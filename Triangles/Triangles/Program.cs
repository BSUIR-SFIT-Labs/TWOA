using System;

namespace Triangles
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side of the triangle: ");
            string firstSide = Console.ReadLine();

            Console.Write("Enter the length of the second side of the triangle: ");
            string secondSide = Console.ReadLine();

            Console.Write("Enter the length of the third side of the triangle: ");
            string thirdSide = Console.ReadLine();

            var triangleChecker = new TriangleChecker(firstSide, secondSide, thirdSide);
            Console.WriteLine($"Result: {triangleChecker.CheckTriangle()}");
        }
    }
}