using GangOfFour.Patterns.Structural.Adapter.Adaptees;
using GangOfFour.Patterns.Structural.Adapter.Stuff;
using GangOfFour.Patterns.Structural.Adapter.Targets;
using System;

namespace GangOfFour.Patterns.Structural.Adapter.Adapters
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class ProductRepositoryV1 : IProductRepository
    {
        public Product GetProductById(Guid id)
        {
            return ProductRepository.TryToGetByIdOrReference(id.ToString());
        }

        public Product GetProductByReference(string reference)
        {
            return ProductRepository.TryToGetByIdOrReference(reference);
        }
    }
}
