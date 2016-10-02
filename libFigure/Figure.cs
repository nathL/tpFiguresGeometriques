using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFigure
{
    public abstract class Figure
    {
        private double x = 1;
        private double y = 1; 

        public Figure() { }

        public Figure(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        abstract public double Surface();

        public String Informations()
        {
            return string.Format("{0:0.00}", x) + " " + string.Format("{0:0.00}", y); 
        }

    }
}
