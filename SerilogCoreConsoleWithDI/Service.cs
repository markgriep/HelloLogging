using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SerilogCoreConsoleWithDI
{

    public interface IService
    {
        void Execute();
    }


    internal class Service : IService
    {
        private int pseudoId = 0;



        public Service()
        {

            pseudoId = DateTime.Now.Millisecond;

            Console.WriteLine($"Service instance created. the PseudoID is {pseudoId}");
        }

        public void Execute()
        {
            Console.WriteLine($"Service instance executed.  PseudoID is {pseudoId}");
        }
    }

}
