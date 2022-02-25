namespace ProductSystem.Products;

using System;
using System.Threading.Tasks;
using Interfaces;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

[Serializable]
public class ProductAppService : CrudAppService<Product, ProductDto, Guid, GetProductsInput, CreateProductInput, UpdateProductInput>, IProductAppService
{
    public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
    {
    }

    public override async Task<ProductDto> CreateAsync(CreateProductInput input)
    {
        await CheckCreatePolicyAsync();

        var entity = await MapToEntityAsync(input);

        if (Repository.AnyAsync(x => x.Name == input.Name) == null)
        {
            throw new UserFriendlyException("There is a product with the same name");
        }

        TryToSetTenantId(entity);

        await Repository.InsertAsync(entity, autoSave: true);

        return await MapToGetOutputDtoAsync(entity);
    }

    [EnableCors("AllowOrigin")]
    public async override Task<PagedResultDto<ProductDto>> GetListAsync(GetProductsInput input)
    {
        await CheckGetListPolicyAsync();

        var query = await CreateFilteredQueryAsync(input);

        var totalCount = await AsyncExecuter.CountAsync(query);

        query = ApplySorting(query, input);
        query = ApplyPaging(query, input);

        var entities = await AsyncExecuter.ToListAsync(query);
        var entityDtos = await MapToGetListOutputDtosAsync(entities);

        return new PagedResultDto<ProductDto>(
            totalCount,
            entityDtos
        );
    }

    protected override async Task<IQueryable<Product>> CreateFilteredQueryAsync(GetProductsInput input)
    {
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(true, d => d.ProductType == input.Type)
            .WhereIf(!string.IsNullOrEmpty(input.SearchFilter), d => EF.Functions.Like(d.Name, input.SearchFilter));
    }
}