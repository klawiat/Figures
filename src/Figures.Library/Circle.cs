using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Library
{
    public class Circle : FigureBase
    {
        #region Свойства
        public readonly double radius;
        #endregion
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new InvalidDataException("Радиус не может быть равен или меньше нуля");
            this.radius = radius;
        }
        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
