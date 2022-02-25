namespace ProductSystem.Products.Interfaces;

using System;
using Volo.Abp.Application.Services;

public interface IProductAppService : ICrudAppService<ProductDto, Guid, GetProductsInput, CreateProductInput, UpdateProductInput>
{

}