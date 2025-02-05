//Lab3: Mutation Test
//Name: Charankanth Reddy Chinthala

using NUnit.Framework;
using NUnit.Framework.Legacy;
using Lab3Mutation;

namespace TriangleTest
{
    [TestFixture]
    public class Trianglestest
    {
        [Test]
        public void TestValidIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 70;
            int secondSide = 60;
            int thirdSide = 40;

            string expected = "The triangle is an isosceles triangle.";

            // Act
            string actual = Triangles.TriangleIsosceles(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

    }
}