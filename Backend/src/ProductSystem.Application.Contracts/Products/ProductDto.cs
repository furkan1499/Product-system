namespace ProductSystem.Products;

using System;
using System.Text.Json.Serialization;
using Volo.Abp.Application.Dtos;

[Serializable]
public class ProductDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType ProductType { get; set; }
}