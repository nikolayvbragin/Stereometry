using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
	public class Cylinder : Shape
	{
		public Cylinder(double radius, double height)
		{
			cylinderRadius = radius;
			cylinderHeight = height;
		}

		private double _cylinderRadius, _cylinderHeight;
		public double cylinderRadius
			{
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Радиус цилиндра не может быть меньше либо равен нулю");
				}
				else
				{
					_cylinderRadius = value;
				}
			}
			get => _cylinderRadius;
			}
		public double cylinderHeight 
		{
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Высота цилиндра не может быть меньше либо равна нулю");
				}
				else
				{
					_cylinderHeight = value;
				}
			}
			get => _cylinderHeight;
		}

		public override double Volume()
		{
			return Math.PI * Math.Pow(cylinderRadius, 2) * cylinderHeight;
		}
	}
}
