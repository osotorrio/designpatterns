using GangOfFour.Patterns.Structural.Adapter.Stuff;
using System;

namespace GangOfFour.Patterns.Structural.Adapter.Targets
{
    /// <summary>
    /// Target
    /// </summary>
    public interface IProductRepository
    {
        Product GetProductById(Guid id);

        Product GetProductByReference(string reference);
    }
}
