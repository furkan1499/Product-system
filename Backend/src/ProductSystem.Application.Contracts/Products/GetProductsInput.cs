namespace ProductSystem.Products;

using System;
using Volo.Abp.Application.Dtos;

[Serializable]
public class GetProductsInput:PagedAndSortedResultRequestDto
{
    public string SearchFilter { get; set; }

    public ProductType Type { get; set; }
}