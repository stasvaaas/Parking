﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public struct Color
    {
        private int _red ;
        private int _green;
        private int _blue;
        private int _opacity;
        public int Red
        {
            get => _red;
            private set
            {
                if (value < 0 || value > 255)
                {
                    _red = 0;
                }
                else
                {
                    _red = value;
                }
            }
        }
        public int Green
        {
            get => _green;
            private set
            {
                if (value < 0 || value > 255)
                {
                    _green = 0;
                }
                else
                {
                    _green = value;
                }
            }
        }
        public int Blue
        {
            get => _blue;
            private set
            {
                if (value < 0 || value > 255)
                {
                    _blue = 0;
                }
                else
                {
                    _blue = value;
                }
            }
        }
        public int Opacity
        {
            get => _opacity;
            private set
            {
                if (value < 0 || value > 100)
                {
                    _opacity = 0;
                }
                else
                {
                    _opacity = value;
                }
            }
        }
        public Color(int red, int green, int blue, int opacity): this()
        {
            Red = red;
            Green = green;
            Blue = blue;
            Opacity = opacity;
        }
        //oveeriding ToString to display colors
        public override string ToString()
        {
            return $"R: {Red}, G: {Green}, B: {Blue}, Op: {Opacity}";
        }
    }
}
