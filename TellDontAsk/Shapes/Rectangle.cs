using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellDontAsk.Shapes
{
	class Rectangle : Shape
	{
		public int Width
		{
			get; set;
		}

		public int Height
		{
			get; set;
		}

		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public override double CalculateArea()
		{
			return Height * Width;
		}

		//	public override void Accept(IVisitor visitor)
		//	{
		//		visitor.VisitRectangle(this);
		//	}

		//	public override double CalculateCircumference()
		//	{
		//		return 2 * (Width + Height);
		//	}
	}
}
