namespace ProductSystem.Products;

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Volo.Abp.Application.Dtos;

[Serializable]
public class CreateProductInput : UpdateProductInput
{
    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType ProductType { get; set; }
}