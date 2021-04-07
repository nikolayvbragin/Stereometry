using System;

namespace Stereometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(8,  10, 'A');
            Point B = new Point(5,  8,  'B');
            Point C = new Point(7,  4,  'C');
            Point D = new Point(12, 3,  'D');
            Point E = new Point(13, 7,  'E');
            
            Polygon Trg = new Polygon(A, B, C);
            Polygon Rct = new Polygon(A, B, C, D);
            Polygon Pnt = new Polygon(A, B, C, D, E);

            Console.WriteLine("Последовательный вывод периметра трех фигур:");
            Console.WriteLine(Trg.Perimetr());
            Console.WriteLine(Rct.Perimetr());
            Console.WriteLine(Pnt.Perimetr());

            //Такие значения заданы для получения осмысленных результатов
            Vector vectorA = new Vector(10, 10, 10, "vectorA");
            Vector vectorB = new Vector(-10, -10, -10, "vectorB");


            vectorA.VectorOut(); 
            vectorB.VectorOut();

            Console.WriteLine($"Длина вектора {vectorA.Name} равна {vectorA.VectorLen()}");
            Console.WriteLine($"Длина вектора {vectorB.Name} равна {vectorB.VectorLen()}");

            double scalar = Vector.ScalarMult(vectorA, vectorB);

            Console.WriteLine($"Скалярное произведение векторов равно {scalar}");
            Vector vectorC = Vector.VectorsMult (vectorA, vectorB, "C");
            Console.WriteLine($"Результат векторного произведения данных векторов помещен в вектор C:");
            vectorC.VectorOut();
            Console.WriteLine($"Угол между векторами {vectorA.Name} и {vectorB.Name} равен {Vector.AngleBtwVectors(vectorA, vectorB)} градусов");
            Vector vectorD = Vector.VectorsSum(vectorA, vectorB, "D");
            Console.WriteLine($"Результат сложения векторов {vectorA.Name} и {vectorB.Name} помещен в вектор D:");
            vectorD.VectorOut();
            Vector vectorE = Vector.VectorsSubt(vectorA, vectorB, "E");
            Console.WriteLine($"Результат разности векторов {vectorA.Name} и {vectorB.Name} помещен в вектор E:");
            vectorE.VectorOut();

        }
    }
}
