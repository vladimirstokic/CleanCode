using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellDontAsk.Shapes
{
	class Circle : Shape
	{
		public int Radius
		{
			get; private set;
		}

		public Circle(int radius)
		{
			Radius = radius;
		}
		//public override void Accept(IVisitor visitor)
		//{
		//	visitor.VisitCircle(this);
		//}

		public override double CalculateArea()
		{
			return Math.Pow(Radius, 2) * Math.PI;
		}

		public /*override */double CalculateCircumference()
		{
			return 2 * Radius * Math.PI;
		}
	}
}
