using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry
{
    public class Polygon
    {
        public List<Point> listOfPoints;

        public Polygon(Point A, Point B, Point C)
        {
            listOfPoints = new List<Point> { A, B, C };
        }
        public Polygon(Point A, Point B, Point C, Point D)
        {
            listOfPoints = new List<Point> { A, B, C, D };
        }
        public Polygon(Point A, Point B, Point C, Point D, Point E)
        {
            listOfPoints = new List<Point> { A, B, C, D, E };
        }

        private double SectionLen(Point p1, Point p2)
        {
            double result = Math.Sqrt((Math.Pow((p2.X-p1.X), 2))+(Math.Pow((p2.Y-p1.Y), 2)));

            return result;
        }

        public double Perimetr()
        {
            double perimResult = 0;
            for (int ind=0; ind<listOfPoints.Count-1; ind++)
            {
                perimResult += SectionLen(listOfPoints[ind], listOfPoints[ind + 1]);
               // Console.WriteLine(perimResult);
            }
            perimResult += SectionLen(listOfPoints[0], listOfPoints[listOfPoints.Count-1]);
            return perimResult;
        }

    }
}
