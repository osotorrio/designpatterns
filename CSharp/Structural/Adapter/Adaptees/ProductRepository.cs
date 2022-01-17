using GangOfFour.Patterns.Structural.Adapter.Stuff;
using System;

namespace GangOfFour.Patterns.Structural.Adapter.Adaptees
{
    /// <summary>
    /// Adaptee
    /// </summary>
    public static class ProductRepository
    {
        public static Product TryToGetByIdOrReference(string idOrReference)
        {
            if (Guid.TryParse(idOrReference, out var id))
            {
                return GetProductById(id);
            }
            else
            {
                return GetProductByReference(idOrReference);
            }
        }

        private static Product GetProductById(Guid id)
        {
            return new Product() { Id = id };
        }

        private static Product GetProductByReference(string reference)
        {
            return new Product() { Reference = reference };
        }
    }
}
