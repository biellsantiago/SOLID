using System;

namespace OCP
{
    public class Impressora : IImpressora
    {
        public void imprimir()
        {
            Console.WriteLine("Impressora imprimiu");
        }
    }
}
