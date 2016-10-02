using libFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Cercle cercle = new Cercle(10);

            Rectangle rectangle = new Rectangle(15, 10, 3, 4);
            Figure[] tabFigure = new Figure[] { rectangle, cercle };

            List<Figure> colFigure = new List<Figure>();
            colFigure.Add(rectangle);
            colFigure.Add(cercle);

            double resultatTab = 0;
            double resultatColl = 0;

            Console.WriteLine("AVEC UN TABLEAU \n");
            foreach(Figure element in tabFigure)
            {
                Type t = element.GetType();
                if (t.Equals(typeof(Cercle)))
                {
                    Console.Write("Cercle centré au point ");
                }
                if (t.Equals(typeof(Rectangle))){
                    Console.Write("Rectangle centré au point ");
                }
                Console.WriteLine(element.Informations());
                 
                resultatTab = resultatTab + element.Surface();
                
            }
            Console.WriteLine("Surface totale : " + Math.Round(resultatTab, 2));
            Console.WriteLine();

            Console.WriteLine("AVEC UNE COLLECTION \n"); 
            foreach(Figure element in colFigure)
            {
                Type t = element.GetType();
                if (t.Equals(typeof(Cercle)))
                {
                    Console.Write("Cercle centré au point ");
                }
                if (t.Equals(typeof(Rectangle)))
                {
                    Console.Write("Rectangle centré au point ");
                }
                Console.WriteLine(element.Informations());

                resultatColl = resultatColl + element.Surface();

            }
            Console.WriteLine("Surface totale : " + Math.Round(resultatColl, 2));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
