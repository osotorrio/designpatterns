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
                // Get the product by id
            }
            else
            {
                // Get the product by reference
            }

            return new Product();
        }
    }
}
