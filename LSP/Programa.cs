using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Forma
    {
        public abstract double Area();
    }

    public class Retangulo : Forma
    {
        public virtual double Largura { get; set; }
        public virtual double AlturaRetangulo { get; set; }

        public override double Area()
        {
            return Largura * AlturaRetangulo;
        }
    }

    public class Quadrado : Forma
    {
        public virtual double LarguraLado { get; set; }

        public override double Area()
        {
            return LarguraLado * LarguraLado;
        }
    }

    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return 0.5 * Base * Altura;
        }
    }


    class Programa
    {
        static void Main(string[] args)
        {
            List<Forma> formas =
                new List<Forma>
                {
                    new Retangulo() { Largura = 3, AlturaRetangulo = 2 },
                    new Quadrado() { LarguraLado = 2 },
                    new Triangulo() { Base = 4, Altura = 2 }
                };

            foreach (Forma forma in formas)
            {
                Console.WriteLine(forma.Area());
            }

            Console.ReadKey(true);
        }
    }
}
