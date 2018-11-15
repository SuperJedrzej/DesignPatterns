using System;
using System.Collections.Generic;

namespace OpenClosedPrincipal
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                    yield return i;
            }
        }

        internal IEnumerable<Product> Filter(AndSpecification<Product> andSpecification)
        {
            throw new NotImplementedException();
        }
    }
}
