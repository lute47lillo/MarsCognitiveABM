using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainGenerator
{
    class Landscape
    {
        protected int Width = 100;
        protected int Height = 100;

        protected int[,] map;

        public Landscape(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            map = new int[this.Height, this.Width];
        }



    }
}
