using System;

namespace SRP
{
    class Programa
    {
        static void Main(string[] args)
        {
            Processador p = new Processador();
            p.processar();

            Console.ReadKey(true);
        }
    }
}
