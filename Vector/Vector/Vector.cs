using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    public class Vector
    {
        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        private double _x = 0;

        public double X
        {
            get => _x;
        
        }

        private double _y = 0;

        public double Y
        {
            get => _y;
        }

        private double _z = 0;

        public double Z
        {
            get => _z;
        }

        public double VectorLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double ScalarComposition(Vector vector)
        {
            return (vector.X * X + vector.Y * Y + vector.Z * Z);
        }

        public Vector VectorComposition(Vector vector)
        {
            double Xnew = (vector.Y * Z - vector.Z * Y);
            double Ynew = (vector.Z * X - vector.X * Z);
            double Znew = (vector.X * Y - vector.Y * X);
            Vector vector1 = new Vector(Xnew, Ynew, Znew);
            return vector1; 
        }

        public double AngleBetweenVectors(Vector vector)
        {
            double scalar = ScalarComposition(vector);
            double a = VectorLength();
            double b = vector.VectorLength();
            double c = Math.Acos(scalar / (a * b));
            return c;
        }

        public Vector VectorSum(Vector vector)
        {
            Vector vector1 = new Vector(vector.X + X, vector.Y + Y, vector.Z + Z);
            return vector1;
        }

        public Vector VectorDif(Vector vector)
        {
            Vector vector1 = new Vector(X - vector.X, Y - vector.Y, Z - vector.Z);
            return vector1;
        }
    }

}
