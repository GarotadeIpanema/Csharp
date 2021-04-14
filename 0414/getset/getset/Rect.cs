using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Rect
    {
        public int w;
        public int h;
        
        public int getArea()
        {
            return w * h;
        }


        private int width;
        public void setWidth(int width)
        {
            if (width < 0)
                this.width = 0;
            else
                this.width = width;
        }
        public int getWidth()
        {
            return this.width;
        }

        private int height;
        public void setHeight(int height)
        {
            if (height < 0)
                this.height = 0;
            this.height = height;
          
        }
        public int getHeight()
        {
            return this.height;
        }


        public int getArea_with_getset()
        {
            return w * h;
        }
    }
}
