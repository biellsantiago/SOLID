using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Processador
    {
        Parser parser;
        Leitora leitora;
        Impressora impressora;

        public Processador()
        {
            parser = new Parser();
            leitora = new Leitora();
            impressora = new Impressora();
        }
        public void processar()
        {
            Console.WriteLine("Processador processou");
            parser.parse();
            leitora.ler();
            impressora.imprimir();
        }
    }
}
