using GangOfFour.Patterns.Structural.Adapter.Adapters;
using GangOfFour.Patterns.Structural.Adapter.Targets;
using System;
using System.Collections.Generic;
using Xunit;

namespace GangOfFour.Patterns.Structural.Adapter.Client
{
    /// <summary>
    /// Application Code
    /// </summary>
    public class Application
    {
        [Theory]
        [MemberData(nameof(InjectDependencies))]
        public void ExampleAddapterPattern(IProductRepository productRepository)
        {
            productRepository.GetProductById(Guid.NewGuid());
            productRepository.GetProductByReference("REF-123-abc");
        }

        public static IEnumerable<object[]> InjectDependencies()
        {
            return new List<object[]>
            {
                new object[] { new ProductRepositoryV1() },
                new object[] { new ProductRepositoryV2() }
            };
        }
    }
}
