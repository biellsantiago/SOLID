using System;

namespace ISP
{
    public class Dev : IMembroDeTimeScrumDev
    {

        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("DESENVOLVENDOOOOO");
        }
    }

    public class ScrumMaster : IFuncaoDeScrumMaster
    {

        public void BlindarTime()
        {
            Console.WriteLine("Desenvolvedores estão programando. Otimo! NINGUEM ATRAPALHA");
        }
        
    }

    public class ProductOwner : IMembroDeTimeScrumOwner
    {
        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando backlog com base nas necessidades de negócio");
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            ProductOwner owner = new ProductOwner();
            ScrumMaster scrum = new ScrumMaster();
            Dev dev = new Dev();

            dev.ImplementarFuncionalidades();
            scrum.BlindarTime();
            owner.PriorizarBacklog();

            Console.ReadKey(true);
        }
    }
}
