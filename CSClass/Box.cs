using System;

namespace CSClass
{
    public class Box
    {
        public int foo
        {
            get;
            set;
        }
        private int width;
        private int height;
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetWidth(int w)
        {
            if (w > 0)
            {
                width = w;
            }
            else
            {
                Console.WriteLine("Box의 가로 길이는 양수여야 합니다.");
            }

        }
        public void SetHeight(int h)
        {
            if (h > 0)
            {
                height = h;
            }
            else
            {
                Console.WriteLine("Box의 세로 길이는 양수여야 합니다.");
            }

        }
        public Box(int width, int height)
        {
            this.SetWidth(width); 
            this.SetHeight(height);

        }
        public int getArea()
        {
            return width * height;
        }

        private int Area
        {
            get
            {
                return this.width * this.height;
            }
        }
    }
}