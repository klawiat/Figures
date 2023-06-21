using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Library
{
    public abstract class FigureBase
    {
        private Lazy<double> _area { get; init; }
        public double Area { get=>_area.Value;}
        protected FigureBase() 
        {
            _area = new Lazy<double>(CalculateArea);
        }
        protected abstract double CalculateArea();
    }
}
