using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdASync(int id);
        Task<IReadOnlyList<Product>> GetProductsASync();
        Task<IReadOnlyList<ProductBrand>> GetProductsBrandsASync();
        Task<IReadOnlyList<ProductType>> GetProductsTypesASync();
    }
}