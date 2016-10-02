using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFigure
{
    public class Cercle : Figure
    {
        private double rayon;

        public Cercle() { }

        public Cercle(double rayon)
        {
            this.rayon = rayon; 
        }

        public override double Surface() {
            return Math.PI * rayon * rayon;
        }
    }
}
