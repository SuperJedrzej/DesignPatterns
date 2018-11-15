using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipal
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T>first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName:nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple",Color.Green,Size.Small);
            var tree = new Product("Tree",Color.Green,Size.Large);
            var house = new Product("House", Color.Blue,Size.Large);

            Product[] products = {apple, tree, house};

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");

            foreach (var p in pf.FilterByColor(products,Color.Green))
                Console.WriteLine($" - {p.Name} is green");

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");

            foreach (var p in bf.Filter(products,new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("Large blue items");
            foreach (var p in
                bf.Filter(products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                )))
            {
                Console.WriteLine($" - {p.Name} is large and blue");
            }

        }
    }
}
