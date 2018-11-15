using System;

namespace InterfaceSegregationPrinciple
{
    public class MultiFunctionalMachine : IMultiFunctionalDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionalMachine(IPrinter printer,IScanner scanner)
        {
            if(printer == null)
                throw new ArgumentNullException(paramName: nameof(printer));
            if(scanner == null)
                throw new ArgumentNullException(paramName: nameof(scanner));
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }
}
