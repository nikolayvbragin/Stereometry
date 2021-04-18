using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
	public class Pyramid : Shape
	{
		public Pyramid(double baseS, double height)
		{
			S = baseS;
			H = height;
		}
		private double _pyramidS, _pyradmidH;	

		public double S 
		{
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Площадь основания пирамиды не может быть меньше либо равной нулю");
				}
				else _pyramidS = value;
				
			}
			get => _pyramidS;
		}
		public double H 
		{
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Высота пирамиды не может быть меньше либо равной нулю");
				}
				else _pyradmidH = value;
			}
			get => _pyradmidH;
		}

		public override double Volume()
		{
			return S * H / 3.0;
		}
	}
}
