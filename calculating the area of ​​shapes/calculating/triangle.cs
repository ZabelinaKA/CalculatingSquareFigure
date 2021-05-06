using System;
using System.Collections.Generic;
using System.Text;

namespace calculating
{
    public class triangle : ITriangle
    {

		public triangle(double edgeA, double edgeB, double edgeC)
		{
			if (edgeA < 0)
				throw new ArgumentException("Неверно указана сторона.", nameof(edgeA));

			if (edgeB < 0)
				throw new ArgumentException("Неверно указана сторона.", nameof(edgeB));

			if (edgeC < 0)
				throw new ArgumentException("Неверно указана сторона.", nameof(edgeC));

			var maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));

			var perimeter = edgeA + edgeB + edgeC;
			if ((perimeter - maxEdge) - maxEdge < 0)
				throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");

			EdgeA = edgeA;
			EdgeB = edgeB;
			EdgeC = edgeC;

			_isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
		}

		public double EdgeA { get; }
		public double EdgeB { get; }
		public double EdgeC { get; }

		private readonly Lazy<bool> _isRightTriangle;
		public bool IsRightTriangle => _isRightTriangle.Value;

		private bool GetIsRightTriangle()
		{
			double t = 0;
			double maxEdge = EdgeA, b = EdgeB, c = EdgeC;
			if (b - maxEdge > 0)
			{
				t = maxEdge;
				maxEdge = b;
				b = t;
			}
			if (c - maxEdge > 0)
			{
				t = maxEdge;
				maxEdge = c;
				c = t;
			}
			return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < 0;
		}

		public double Square()
		{
			var halfP = (EdgeA + EdgeB + EdgeC) / 2;
			var square = Math.Sqrt(
				halfP
				* (halfP - EdgeA)
				* (halfP - EdgeB)
				* (halfP - EdgeC)
			);

			return square;
		}
	}
}
