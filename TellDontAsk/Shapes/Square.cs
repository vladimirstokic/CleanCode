using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellDontAsk.Shapes
{
	class Square : Shape
	{
		public int Side
		{
			get; set;
		}

		public Square(int side)
		{
			Side = side;
		}

		public override double CalculateArea()
		{
			return Math.Pow(Side, 2);
		}

		//	public override void Accept(IVisitor visitor)
		//	{
		//		visitor.VisitSquare(this);
		//	}

		//	public override double CalculateCircumference()
		//	{
		//		return 4 * Side;
		//	}
	}
}
