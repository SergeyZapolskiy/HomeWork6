using System;
using System.Collections.Generic;
using System.Text;

namespace PerimetrCalculation
{
    public class Point
    {
        public Point(int x, int y, int namePoint)
        {
            //int z = 0;
            //Console.WriteLine("Enter the number:\n");
            //while (z != 5)
            //{
            //    if (int.TryParse(Console.ReadLine(), out x))
            //    {
            //        _x = x;
            //        z = 5;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You entered the number incorrectly!");
            //    }
            //}
            //Console.WriteLine("Enter the number:\n");
            //while ( z != 6)
            //{

            //    if (int.TryParse(Console.ReadLine(), out y))
            //    {
            //        _y = y;
            //        z = 6;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You entered the number incorrectly!");
            //    }
            //}
            _x = x;
            _y = y;
            _namePoint = namePoint;
        }

        private int x = 0;
        private int y = 0;

        private int _x = 0;

        public int X
        {
            get => _x;
        }

        private int _y = 0;

        public int Y
        {
            get => _y;
        }

        private int _namePoint;

        public int NamePoint
        {
            get => _namePoint;
        }
    }
}
