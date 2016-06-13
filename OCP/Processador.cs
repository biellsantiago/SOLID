using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Processador
    {
        ILeitora leitora;
        IImpressora impressora;
        IParser parser;
        
        public Processador(ILeitora iLeitora, IImpressora iImpressora, IParser iParser)
        {
            this.leitora = iLeitora;
            this.impressora = iImpressora;
            this.parser = iParser;
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
