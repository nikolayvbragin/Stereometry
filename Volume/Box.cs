using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
	public class Box : Shape
	{
		private double _usedVolume;

		//public double Height { get; set; }

        private double _height;
		public Box(double edge)
		{
			if (edge <= 0)
			{
				Console.WriteLine("_Конструктор_ Сторона квадрата не может быть меньше либо равна нулю");
			}
			else Height = edge;
		}

		public double Height
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("_Сеттер_ Сторона квадрата не может быть меньше либо равна нулю");
                }
                else
                {
                    _height = value;
                }
            }
            get => _height;
        }

        
       
		
		public double FreeVolume()
		{
			return Volume() - _usedVolume;
		}

		public bool Add(Shape shape)
		{
			double remainingVolume = FreeVolume();
			double shapeVolume = shape.Volume();

			if (remainingVolume >= shapeVolume)
			{
				
				_usedVolume += shapeVolume;

				return true;
			}
			else
			{
				return false;
			}
		}


		public override double Volume()
		{
			return Math.Pow(Height, 3);
		}
	}
}

