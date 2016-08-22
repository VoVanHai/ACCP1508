using System;

namespace Session03
{
    public class Rectangular_CS
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public double area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return String.Format("Rectangular ({0},{1})", Width, Height);
        }
    }
}
