using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_With_Winforms.Geometry
{
    /// <summary>
    /// May use it when updating this app in the future, or for some other app.
    /// </summary>
    internal static class Rectangle
    {
        public static double Perimeter(double Width, double Height)
        {
            return Width * 2 + Height * 2;// or 2 * (Width + Height)
        }
        public static double Area(double Width, double Height)
        {
            return Width * Height;
        }
        public static double Diagonal(double Width, double Height)
        {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }
    }
}
