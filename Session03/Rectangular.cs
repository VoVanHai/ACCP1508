using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    public class Rectangular
    {
        //instance data / states
        private int width;
        private int height;

        //constructor
        public Rectangular(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public int getWidth()
        {
            return width;
        }
        public void setWidth(int width)
        {
            if (width <= 0) throw new Exception("invalid width");
            this.width = width;
        }
        public int getHeight()
        {
            return width;
        }
        public void setHeight(int height)
        {
            if (width <= 0) throw new Exception("invalid Height");
            this.height = height;
        }
        //methods
        public double area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return String.Format("Rectangular ({0},{1})", width, height);
        }

    }
}
