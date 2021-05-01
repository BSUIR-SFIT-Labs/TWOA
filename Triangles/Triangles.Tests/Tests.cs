using NUnit.Framework;

namespace Triangles.Tests
{
    public class Tests
    {
        [Test]
        public void TriangleNotExistTest_Input_10_1_1()
        {
            const string firstSide = "10";
            const string secondSide = "1";
            const string thirdSide = "1";

            const string expectedMessage = Message.TriangleNotExist;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void TriangleNotExistTest_Input_1_10_1()
        {
            const string firstSide = "1";
            const string secondSide = "10";
            const string thirdSide = "1";

            const string expectedMessage = Message.TriangleNotExist;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void TriangleNotExistTest_Input_1_1_10()
        {
            const string firstSide = "1";
            const string secondSide = "1";
            const string thirdSide = "10";

            const string expectedMessage = Message.TriangleNotExist;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void UsualTriangleTest_Input_11_12_13()
        {
            const string firstSide = "11";
            const string secondSide = "12";
            const string thirdSide = "13";

            const string expectedMessage = Message.UsualTriangle;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void EquilateralTriangleTest_Input_10_10_10()
        {
            const string firstSide = "10";
            const string secondSide = "10";
            const string thirdSide = "10";

            const string expectedMessage = Message.EquilateralTriangle;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void IsoscelesTriangleTest_Input_10_10_15()
        {
            const string firstSide = "10";
            const string secondSide = "10";
            const string thirdSide = "15";

            const string expectedMessage = Message.IsoscelesTriangle;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void IsoscelesTriangleTest_Input_10_15_10()
        {
            const string firstSide = "10";
            const string secondSide = "15";
            const string thirdSide = "10";

            const string expectedMessage = Message.IsoscelesTriangle;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void IsoscelesTriangleTest_Input_15_10_10()
        {
            const string firstSide = "15";
            const string secondSide = "10";
            const string thirdSide = "10";

            const string expectedMessage = Message.IsoscelesTriangle;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void NumberOutOfRangeTest_Input_0_10_15()
        {
            const string firstSide = "0";
            const string secondSide = "10";
            const string thirdSide = "15";

            const string expectedMessage = Message.NumberOutOfRange;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void NumberOutOfRangeTest_Input_1_2_11111111111111111111()
        {
            const string firstSide = "1";
            const string secondSide = "2";
            const string thirdSide = "11111111111111111111";

            const string expectedMessage = Message.NumberOutOfRange;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void NumberOutOfRangeTest_Input_0_0_0()
        {
            const string firstSide = "0";
            const string secondSide = "0";
            const string thirdSide = "0";

            const string expectedMessage = Message.NumberOutOfRange;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void NegativeNumberTest_Input_minus5_1_3()
        {
            const string firstSide = "-5";
            const string secondSide = "1";
            const string thirdSide = "3";

            const string expectedMessage = Message.NegativeNumber;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void NegativeNumberTest_Input_minus5_minus3_3()
        {
            const string firstSide = "-5";
            const string secondSide = "-3";
            const string thirdSide = "3";

            const string expectedMessage = Message.NegativeNumber;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void NegativeNumberTest_Input_minus5_minus3_minus4()
        {
            const string firstSide = "-5";
            const string secondSide = "-3";
            const string thirdSide = "-4";

            const string expectedMessage = Message.NegativeNumber;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void FloatNumberTest_Input_1point2_3_4()
        {
            const string firstSide = "1.2";
            const string secondSide = "3";
            const string thirdSide = "4";

            const string expectedMessage = Message.FloatNumber;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void FloatNumberTest_Input_1point2_3_5point3()
        {
            const string firstSide = "1.2";
            const string secondSide = "3";
            const string thirdSide = "5.3";

            const string expectedMessage = Message.FloatNumber;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void FloatNumberTest_Input_1point2_3point3_5point3()
        {
            const string firstSide = "1.2";
            const string secondSide = "3.3";
            const string thirdSide = "5.3";

            const string expectedMessage = Message.FloatNumber;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void LetterCharactersTest_Input_a_3_5()
        {
            const string firstSide = "a";
            const string secondSide = "3";
            const string thirdSide = "5";

            const string expectedMessage = Message.LetterCharacters;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void LetterCharactersTest_Input_a_3_a()
        {
            const string firstSide = "a";
            const string secondSide = "3";
            const string thirdSide = "a";

            const string expectedMessage = Message.LetterCharacters;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void LetterCharactersTest_Input_a_b_a()
        {
            const string firstSide = "a";
            const string secondSide = "b";
            const string thirdSide = "a";

            const string expectedMessage = Message.LetterCharacters;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void EmptyStringTest_Input_empty_3_5()
        {
            const string firstSide = "";
            const string secondSide = "3";
            const string thirdSide = "5";

            const string expectedMessage = Message.EmptyString;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void EmptyStringTest_Input_2_empty_empty()
        {
            const string firstSide = "2";
            const string secondSide = "";
            const string thirdSide = "";

            const string expectedMessage = Message.EmptyString;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        [Test]
        public void EmptyStringTest_Input_empty_empty_empty()
        {
            const string firstSide = "";
            const string secondSide = "";
            const string thirdSide = "";

            const string expectedMessage = Message.EmptyString;

            TestTriangle(firstSide, secondSide, thirdSide, expectedMessage);
        }

        private static void TestTriangle(string firstSide, string secondSide, string thirdSide, string expectedMessage)
        {
            var triangleChecker = new TriangleChecker(firstSide, secondSide, thirdSide);
            string resultOfChecking = triangleChecker.CheckTriangle();

            Assert.AreEqual(expectedMessage, resultOfChecking);
        }
    }
}