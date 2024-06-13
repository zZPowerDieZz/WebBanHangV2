using System;

namespace TestProject3
{
    internal class Cart
    {
        public Cart()
        {
        }

        public object Items { get; internal set; }

        internal void add(Product p1, int v)
        {
            throw new NotImplementedException();
        }
    }
}