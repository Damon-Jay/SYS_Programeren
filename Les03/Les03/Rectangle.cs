using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Rectangle
    {

        private float x;
        private float y;
        private float width;
        private float height;



        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }

        public Rectangle(float x, float y, float size)
        {
            this.width = size;
            this.height = size;
        }
    }
}