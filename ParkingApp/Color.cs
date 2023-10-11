using System;
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

        private bool IsColorValid(int colorValue)
        {
            return colorValue >= 0 && colorValue <= 255;
        }

        private bool IsOpacityValid(int opacityValue)
        {
            return opacityValue >= 0 && opacityValue <= 100;
        }

        public int Red
        {
            get => _red;
            private set
            {
                if (IsColorValid(value))
                {
                    _red = value;
                }
                else
                {
                    _red = 0;
                }
            }
        }

        public int Green
        {
            get => _green;
            private set
            {
                if (IsColorValid(value))
                {
                    _green = value;
                }
                else
                {
                    _green = 0;
                }
            }
        }

        public int Blue
        {
            get => _blue;
            private set
            {
                if (IsColorValid(value))
                {
                    _blue = value;
                }
                else
                {
                    _blue = 0;
                }
            }
        }

        public int Opacity
        {
            get => _opacity;
            private set
            {
                if (IsOpacityValid(value))
                {
                    _opacity = value;
                }
                else
                {
                    _opacity = 0;
                }
            }
        }

        //constructor if the color cannot be indentified, but opacity can
        public Color(int opacity):this()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
            Opacity = opacity;
        }

        // fully indentified color constructor
        public Color(int red, int green, int blue, int opacity): this()
        {
            Red = red;
            Green = green;
            Blue = blue;
            Opacity = opacity;
        }

        //overriding ToString to display colors
        public override string ToString()
        {
            return $"R: {Red}, G: {Green}, B: {Blue}, Op: {Opacity}";
        }
    }
}
