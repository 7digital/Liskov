using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple2 {
    class CodeSmells {
		void DrawShape(Shape shape)
		{
			if (shape.GetType() == typeof (Square))
			{
				DrawSquare((Square) (shape));
			} else if (shape.GetType() == typeof (Triangle))
			{
				DrawTriangle((Triangle) (shape));
			} else if (shape.GetType() == typeof (Circle))
			{
				DrawCircle((Circle) (shape));
			}
		}

    	private void DrawCircle(Circle o)
    	{
    		// draw circle implementaton goes here
			throw new NotImplementedException();
    	}

    	private void DrawSquare(Square o)
    	{
			// draw square implementaton goes here
    		throw new NotImplementedException();
    	}
		private void DrawTriangle(Triangle o) {
			// draw triangle implementaton goes here
			throw new NotImplementedException();
		}
	}

	internal class Shape {}
	internal class Triangle : Shape	{}
	internal class Square :Shape {}
	internal class Circle :Shape{}
}
