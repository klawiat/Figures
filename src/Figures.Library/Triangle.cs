using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Figures.Library
{
    public class Triangle : FigureBase
    {
        #region Свойства
        public readonly double AB;
        public readonly double BC;
        public readonly double CA;
        public bool IsRectangular { get; init; }
        #endregion
        public Triangle(double AB, double BC, double CA)
        {
            if (AB <= 0 || BC <= 0 || CA <= 0)
                throw new InvalidDataException("Сторона треугольника не может быть равна или меньше нуля");
            this.AB = AB;
            this.BC = BC;
            this.CA = CA;
            IsRectangular = RightAngleTest();
        }
        protected override double CalculateArea()
        {
            double S = (AB + BC + CA)/2;
            return Math.Sqrt(S*(S-AB)*(S-BC)*(S-CA));
        }
        private bool RightAngleTest()
        {
            List<double> sides = new();
            sides.Add(Math.Pow(AB, 2));
            sides.Add(Math.Pow(BC, 2));
            sides.Add(Math.Pow(CA, 2));
            var max = sides.Max();
            sides.Remove(max);
            return max==sides.Sum();
        }
    }
}
