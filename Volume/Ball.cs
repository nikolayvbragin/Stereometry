using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
	public class Ball : Shape
	{
		
		public Ball(double ballR)
		{
			Radius = ballR;
		}

		private double _ballRadius;
		public double Radius 
		
		{
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Радиус шара не может быть меньше либо равен нулю");
				}
				else _ballRadius = value;
			}
			get => _ballRadius;


		}

		public override double Volume()
		{
			return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
		}
	}
}
