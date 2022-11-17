using ShopeeFake.Commons;
using ShopeeFake.Dto;
using ShopeeFake.Models;

namespace ShopeeFake.Services.Interface
{
    public interface IProductService
    {
        Task<ApiResult<ProductDto>> GetProducById(long productId);

        Task<IEnumerable<Product>> GetProductBySale();

        Task<ApiResult<long>> CreateProduct(ProductDto productDto);

        Task<ApiResult<ProductDto>> UpdateProduct(ProductDto productDto);

        Task<ApiResult<long>> DeleteProduct(long productId);

        Task<IEnumerable<Product>> Search(string productName);
    }
}