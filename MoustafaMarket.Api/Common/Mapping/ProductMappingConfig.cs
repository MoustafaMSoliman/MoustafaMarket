using Mapster;
using MoustafaMarket.Application.Services.Products.Command;
using MoustafaMarket.Application.Services.Products.Common;
using MoustafaMarket.Contracts.Product;

namespace MoustafaMarket.Api.Common.Mapping;

public class ProductMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateProductRequest,CreateProductCommand>()
            .Map(dest=>dest.Name, src=>src.Name)
            .Map(dest=>dest.Description, src=>src.Description)
            .Map(dest=>dest.Money.Amount, src=>src.Money.Amount)
            .Map(dest=>dest.Money.Currency,src=>src.Money.Currency)
            .Map(dest=>dest.Dimensions.Length, src=>src.Dimensions.Length)
            .Map(dest=>dest.Dimensions.Width, src=>src.Dimensions.Width)
            .Map(dest=>dest.Dimensions.Height, src=>src.Dimensions.Height)
            .Map(dest=>dest.Images, src=>src.Images)
            .Map(dest=>dest.Quantity, src=>src.Quantity)
            .Map(dest=>dest.CategoryId, src=>src.CategoryId);

        config.NewConfig<ProductDTO, RegisterProductResponse>();
            


    }
}
