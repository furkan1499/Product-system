using AutoMapper;

namespace ProductSystem;

using Products;

public class ProductSystemApplicationAutoMapperProfile : Profile
{
    public ProductSystemApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();

        CreateMap<CreateProductInput, Product>();

        CreateMap<UpdateProductInput, Product>();
    }
}
