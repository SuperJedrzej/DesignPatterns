using System.Collections.Generic;

namespace OpenClosedPrincipal
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size)
                    yield return p;
            }
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                    yield return p;
            }
        }
    }
}
