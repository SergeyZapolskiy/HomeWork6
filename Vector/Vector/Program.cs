using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(1, 4, 8);
            Vector vector2 = new Vector(-2, 4, -9);
            var a1 = vector1.VectorLength();
            var a2 = vector1.ScalarComposition(vector2);
            var a3 = vector1.VectorComposition(vector2);
            var a4 = vector1.AngleBetweenVectors(vector2);
            var a5 = vector1.VectorSum(vector2);
            var a6 = vector1.VectorDif(vector2);
            Console.WriteLine($"Vector length: {a1}\nScalar composition of vectors: {a2}\nVector composition: {a3.X}, {a3.Y}, {a3.Z}\n" +
                $"Angle between vectors: {a4}\nVectors sum: {a5.X}, {a5.Y}, {a5.Z}\nVector dif: {a6.X}, {a6.Y}, {a6.Z}");
            
        }
    }
}
