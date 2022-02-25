namespace ProductSystem.Products;

using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

[Serializable]
public class UpdateProductInput : EntityDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(300)]
    public string Description { get; set; }
}