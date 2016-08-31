namespace Session06
{
    public class Rectangular
    {
        private int length;
        private int width;

        public Rectangular(int length,int width)
        {
            Length = length;
            Width=width;
        }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidRecValues("Invalid length");
                length = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidRecValues("Invalid width");
                width = value;
            }
        }

        public double perimeter()
        {
            return (length + width) * 2;
        }
        public double area()
        {
            return length * width;
        }
    }
}
