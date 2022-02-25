namespace ProductSystem.Products;

using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities.Auditing;

[Audited]
public class Product : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public ProductType ProductType { get; set; }
}