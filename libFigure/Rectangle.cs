using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFigure
{
    public class Rectangle : Figure
    {
        private double longueur;
        private double largeur;

        public Rectangle() { }

        public Rectangle(double longueur, double largeur, double x, double y): base(x, y)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public override double Surface()
        {
            return longueur * largeur;
        }
    }
}
