using System;
using Xunit;
using Stereometry; // Без этого не работает
namespace Vectors.Test
{
    public class UnitTestVectors
    {
        [Fact]
        public void PerimetrTriangleTest()
        {
            Point a = new Point(-5, 5, 'A');
            Point b = new Point(5, 5, 'B');
            Point c = new Point(5, -5, 'C');
            
            Polygon testPolygon = new Polygon(a, b, c);

            var result = testPolygon.Perimetr();

            Assert.Equal(34.14, result, 2);
        }


        [Fact]
        public void PerimetrTest()
        {
            Point a = new Point(-5, 5, 'A');
            Point b = new Point(5, 5, 'B');
            Point c = new Point(5, -5, 'C');
            Point d = new Point(-5, -5, 'D'); 
            Polygon testPolygon = new Polygon(a, b, c, d);

            var result = testPolygon.Perimetr();

            Assert.Equal(40, result);
        }


        [Fact]
        public void PerimetrPentagonTest()
        {
            Point a = new Point(-5, 5, 'A');
            Point b = new Point(5, 5, 'B');
            Point c = new Point(5, -5, 'C');
            Point d = new Point(-5, -5, 'D');
            Point e = new Point(-10, 0, 'E');
            Polygon testPolygon = new Polygon(a, b, c, d, e);

            var result = testPolygon.Perimetr();

            Assert.Equal(44.14, result, 2); ;
        }

        [Theory]
        [InlineData( 5, 5, 5, "A")]

        public void VectorLenghtTest( double x, double y, double z, string name)
        {
            Vector testVector = new Vector(x, y, z, name);
            double result = testVector.VectorLen();
            Assert.Equal(8.66, result, 1);

        }


        [Fact]
        public void testScalarMult()
        {
            Vector vectorA = new Vector(5, 3, 6, "A");
            Vector vectorB = new Vector( -3, -5, -7, "B");

            double result = Vector.ScalarMult(vectorA, vectorB);

            Assert.Equal(-72, result, 0);
        }

        [Fact]
        public void testVectorsMult()
        {
            Vector vectorA = new Vector(5, 3, 6, "A");
            Vector vectorB = new Vector(-3, -5, -7, "B");

            Vector vectorC = Vector.VectorsMult(vectorA, vectorB, "C");

            Assert.Equal(9, vectorC.X);
            Assert.Equal(17, vectorC.Y);
            Assert.Equal(-16, vectorC.Z);
        }

        [Fact]
        public void testVectorsSum()
        {
            Vector vectorA = new Vector(5, 3, 6, "A");
            Vector vectorB = new Vector(-3, -5, -7, "B");

            Vector vectorC = Vector.VectorsSum(vectorA, vectorB, "C");

            Assert.Equal(2, vectorC.X);
            Assert.Equal(-2, vectorC.Y);
            Assert.Equal(-1, vectorC.Z);
        }

        [Fact]
        public void testVectorsSubt()
        {
            Vector vectorA = new Vector(5, 3, 6, "A");
            Vector vectorB = new Vector(-3, -5, -7, "B");

            Vector vectorC = Vector.VectorsSubt(vectorA, vectorB, "C");

            Assert.Equal(8, vectorC.X);
            Assert.Equal(8, vectorC.Y);
            Assert.Equal(13, vectorC.Z);
        }

        [Fact]
        public void testAngleBtwVectors()
        {
            Vector vectorA = new Vector(5, 5, 5, "A");
            Vector vectorB = new Vector(-5, -5, -5, "B");

            double result = Vector.AngleBtwVectors(vectorA, vectorB);

            Assert.Equal(180, result, 0);
          
        }




    }
}
