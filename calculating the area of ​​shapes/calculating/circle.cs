using System;



namespace calculating
{
    public class circle : IFigure
    {
		private const double Pi = Math.PI;
		public circle(double radius)
		{
			if (radius <= 0)
				throw new ArgumentException("Неверно указан радиус круга.", nameof(radius));
			Radius = radius;
		}

		public double Radius { get; }

		public double Square()
		{
			var square = Pi * Math.Pow(Radius, 2);
			return square;
		}
	}

    

}
    

    
