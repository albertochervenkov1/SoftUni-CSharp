﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double l,double w,double h)
        {
            this.Height = h;
            this.Width = w;
            this.Length =l;
        }
        public double Length 
        {
            get => this.length;
            private set 
            {
                if (value<=0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width 
        {
            get => this.width;
            private set 
            {
                if (value<=0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;

            }
        }
        public double Height 
        {
            get => this.height;
            private set 
            {
                if (value<=0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double CalculateVolume() 
        {
            return this.Length * this.Width * this.Height;
        }
        public double CalculateLateralSurface() 
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        }
        public double CalculateSurfaceArea() 
        {
            //2lw + 2lh + 2wh
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        }
    }
}
