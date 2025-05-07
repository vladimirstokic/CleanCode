using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellDontAsk.Shapes;

namespace TellDontAsk
{
	class Program
	{
		static void Main(string[] args)
		{
			Square square = new Square(5);
			Circle circle = new Circle(4);
			Rectangle rectangle = new Rectangle(4, 3);

			//#region
			//Console.WriteLine(CalculateAreaForSquare(square));
			//Console.WriteLine(CalculateAreaForCircle(circle));
			//Console.WriteLine(CalculateAreaForRectangle(rectangle));
			//#endregion
			//Console.WriteLine(square.CalculateArea());
			//Console.WriteLine(circle.CalculateArea());
			//Console.WriteLine(rectangle.CalculateArea());

			//AreaCalculationVisitor acv = new AreaCalculationVisitor();
			//square.Accept(acv);
			//Console.WriteLine(acv.CalculatedArea);
			//circle.Accept(acv);
			//Console.WriteLine(acv.CalculatedArea);
			//rectangle.Accept(acv);
			//Console.WriteLine(acv.CalculatedArea);

			//Console.WriteLine(CalculateCircumferenceForSquare(square));
			Console.WriteLine(CalculateCircumferenceForCircle(circle));
			//Console.WriteLine(CalculateCircumferenceForRectangle(rectangle));

			//Console.WriteLine(square.CalculateCircumference());
			//Console.WriteLine(circle.CalculateCircumference());
			//Console.WriteLine(rectangle.CalculateCircumference());

			//CircumferenceCalculationVisitor ccv = new CircumferenceCalculationVisitor();
			//square.Accept(ccv);
			//Console.WriteLine(ccv.Circumference);
			//circle.Accept(ccv);
			//Console.WriteLine(ccv.Circumference);
			//rectangle.Accept(ccv);
			//Console.WriteLine(ccv.Circumference);

			List<Shape> shapes = new List<Shape>() { square, circle, rectangle };

			foreach (Shape shape in shapes)
			{
				Console.WriteLine(shape.CalculateArea());
			}

			//foreach (Shape shape in shapes)
			//{
			//	Console.WriteLine(shape.CalculateCircumference());
			//}

			//foreach (Shape shape in shapes)
			//{
			//	shape.Accept(acv);
			//	Console.WriteLine(acv.CalculatedArea);
			//}

			//foreach (Shape shape in shapes)
			//{
			//	shape.Accept(ccv);
			//	Console.WriteLine(ccv.Circumference);
			//}

			//ShapeDiagonalCalculator sdc = new ShapeDiagonalCalculator();
			//foreach (Shape shape in shapes)
			//{
			//	shape.Accept(sdc);
			//	Console.WriteLine(sdc.Diagonal);
			//}

		}

		//public static double CalculateAreaForSquare(Square square)
		//{
		//	return Math.Pow(square.Side, 2);
		//}

		//public static double CalculateAreaForCircle(Circle circle)
		//{
		//	return Math.Pow(circle.Radius, 2) * Math.PI;
		//}

		//public static double CalculateAreaForRectangle(Rectangle rectangle)
		//{
		//	return rectangle.Height * rectangle.Width;
		//}

		//public static double CalculateCircumferenceForSquare(Square square)
		//{
		//	return 4 * square.Side;
		//}

		public static double CalculateCircumferenceForCircle(Circle circle)
		{
			return circle.Radius * 2 * Math.PI;
		}

		//public static double CalculateCircumferenceForRectangle(Rectangle rectangle)
		//{
		//	return 2 * (rectangle.Height + rectangle.Width);
		//}
	}
}
