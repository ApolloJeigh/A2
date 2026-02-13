using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public class Rectangle
    {
        private int length;
        private int width;

        // default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // non-default constructor
        public Rectangle(int length, int width)
        {
            if (length >= 1 && length <= 4500)
                this.length = length;
            else
                this.length = 1;
            if (width >= 1 && width <= 4500)
                this.width = width;
            else
                this.width = 1;

        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            if (length >= 1 && length <= 4500)
                this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            if (width >= 1 && width <= 4500)
                this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
