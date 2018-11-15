using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public interface IPrinter
    {
        void Print(Document d);
    }
    public interface IScanner
    {
        void Scan(Document d); 
    }

    public interface IMultiFunctionalDevice : IPrinter, IScanner
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
