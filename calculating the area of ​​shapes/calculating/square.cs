using System;
using System.Collections.Generic;
using System.Text;

namespace calculating
{
   public interface IFigure
    {
        double Square();
    }
	public interface ITriangle : IFigure
	{
		double EdgeA { get; }
		double EdgeB { get; }
		double EdgeC { get; }

		bool IsRightTriangle { get; }
	}
}
