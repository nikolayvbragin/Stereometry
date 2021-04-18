using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry
{
    public class Vector
    {
        public string Name="nullVector";
        public double X=0;
        public double Y=0;
        public double Z=0;


        public Vector( double x, double y, double z, string name )
        {
            
            X = x;
            Y = y;
            Z = z;
            Name = name;
        }

        public double VectorLen()
        {
            try
            {
                double result = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
                return result;
            }
            catch 
            {
                Console.WriteLine("Ошибка при расчете длины вектора, возможно, некоррентные входные данные");
                return 0;
            }
        }

        public static double ScalarMult(Vector vA, Vector vB)
        {
            try
            {
                double result = (vA.X * vB.X) + (vA.Y * vB.Y) + (vA.Z * vB.Z);
                return result;
            }
            catch 
            {
                Console.WriteLine("Ошибка при расчете скалярного произведения");
                return 0;
            }
        }

        public static Vector VectorsMult(Vector vA, Vector vB, string newOutVector)
        {
            try
            {
                double outX = (vA.Y * vB.Z) - (vA.Z * vB.Y);
                double outY = (vA.Z * vB.X) - (vA.X * vB.Z);
                double outZ = (vA.X * vB.Y) - (vA.Y * vB.X);
                Vector result = new Vector( outX, outY, outZ, newOutVector);
                return result;
            }
            catch 
            {
                Console.WriteLine("Ошибка при расчёте векторного произведения");
                return null;
            }
        }

        public static double AngleBtwVectors(Vector vA, Vector vB)
        {
            try
            {
                double sclrMlt = ScalarMult(vA, vB);
                double vAabsLen = Math.Abs(vA.VectorLen());
                double vBabsLen = Math.Abs(vB.VectorLen());
                if (vAabsLen != 0 && vBabsLen != 0)
                {
                    double angleRad = Math.Acos(sclrMlt / (vAabsLen * vBabsLen));
                    return angleRad * (180 / Math.PI);
                }
                else
                {
                    Console.WriteLine("Ошибка при расчёте угла между векторами (один из векторов нулевой длины)");
                    return 0;
                }

            }
            catch 
            {
                Console.WriteLine("Ошибка при расчёте угла между векторами");
                return 0;
            }
        }

        public static Vector VectorsSum(Vector vA, Vector vB, string newOutVector)
        {
            try
            {
                double outX = (vA.X + vB.X);
                double outY = (vA.Y + vB.Y);
                double outZ = (vA.Z + vB.Z);
                Vector result = new Vector(outX, outY, outZ, newOutVector);
                return result;
            }
            catch 
            {
                Console.WriteLine("Ошибка при расчете суммы векторов");
                return null;
            }
        }


        public static Vector VectorsSubt(Vector vA, Vector vB, string newOutVector)
        {
            try
            {
                double outX = (vA.X - vB.X);
                double outY = (vA.Y - vB.Y);
                double outZ = (vA.Z - vB.Z);
                Vector result = new Vector( outX, outY, outZ, newOutVector);
                return result;
            }
            catch
            {
                Console.WriteLine("Ошибка при расчете разности векторов");
                return null;
            }
        }

        public void VectorOut()
        {
            Console.WriteLine($"Координаты вектора {Name}:   Х: {X},  Y: {Y},  Z: {Z}");
        }

    }
}
