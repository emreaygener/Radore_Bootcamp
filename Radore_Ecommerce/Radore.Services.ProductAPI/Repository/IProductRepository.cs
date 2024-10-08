﻿using Radore.Services.ProductAPI.Dto;

namespace Radore.Services.ProductAPI.Repository
{
    public interface IProductRepository
    { 
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
