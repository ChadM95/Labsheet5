using System;
namespace Ex3
{
	public class Rectangle
	{
		public int Length { get; set; }
		public int Width { get; set; }

		public Rectangle(int length, int width)
		{
			Length = length;
			Width = width;
		}

		public int CalcPerimeter()
		{
			return (Length * 2) + (Width * 2);
		}

		public int CalcArea()
		{
			return Length * Width;
		}

	}
}

