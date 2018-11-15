using System;

namespace OpenClosedPrincipal
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
             if(name==null)
                 throw new ArgumentNullException(paramName:nameof(name));

            Name = name;
            Color = color;
            Size = size;
        }
    }
}
