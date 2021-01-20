using GangOfFour.Patterns.Structural.Adapter.Adaptees;
using GangOfFour.Patterns.Structural.Adapter.Stuff;
using GangOfFour.Patterns.Structural.Adapter.Targets;
using System;

namespace GangOfFour.Patterns.Structural.Adapter.Adapters
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class ProductRepositoryV2 : IProductRepository
    {
        public Product GetProductById(Guid id)
        {
            return GetProductByReference(id.ToString());
        }

        public Product GetProductByReference(string reference)
        {
            return ProductRepository.TryToGetByIdOrReference(reference);
        }
    }
}
