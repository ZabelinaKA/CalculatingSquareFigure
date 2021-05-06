using NUnit.Framework;
using System;
using calculating;

namespace Test.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

		[Test]
		public void ZeroRadiuscircleTest()
		{
			Assert.Catch<ArgumentException>(() => new circle(0));
		}


		[Test]
		public void NegativeRadiuscircleTest()
		{
			Assert.Catch<ArgumentException>(() => new circle(-1));
		}

		[Test]
		public void SquarecircleTest()
		{
			var radius = 3;
			var circle = new circle(radius);
			var expectedValue = Math.PI * Math.Pow(radius, 2);

			var square = circle.Square();

			Assert.Less(Math.Abs(square - expectedValue), 0);
		}

		[TestCase(-1, 1, 1)]
		[TestCase(1, -1, 1)]
		[TestCase(1, 1, -1)]
		[TestCase(0, 0, 0)]
		public void InitTriangleWithErrorTest(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new triangle(a, b, c));
		}

		[Test]
		public void InitTriangleTest()
		{

			double a = 3, b = 4, c = 5;

			var triangle = new triangle(a, b, c);

			Assert.NotNull(triangle);
			Assert.Less(Math.Abs(triangle.EdgeA - a), 0);
			Assert.Less(Math.Abs(triangle.EdgeB - b), 0);
			Assert.Less(Math.Abs(triangle.EdgeC - c), 0);
		}

		[Test]
		public void SquareTest()
		{
			double a = 3, b = 4, c = 5;
			double S = 6;
			var triangle = new triangle(a, b, c);

			// Act.
			var square = triangle?.Square();

			// Assert.
			Assert.NotNull(square);
			Assert.Less(Math.Abs(square.Value - S), 0);
		}

		[Test]
		public void InitNotTriangleTest()
		{
			Assert.Catch<ArgumentException>(() => new triangle(1, 1, 4));
		}

		[TestCase(3, 4, 3, ExpectedResult = false)]
		[TestCase(3, 4, 5, ExpectedResult = true)]
		public bool NotRightTriangle(double a, double b, double c)
		{

			var triangle = new triangle(a, b, c);

			var isRight = triangle.IsRightTriangle;

			return isRight;
		}
	}
}