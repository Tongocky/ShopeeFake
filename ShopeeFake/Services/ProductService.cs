using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using ShopeeFake.Commons;
using ShopeeFake.Data;
using ShopeeFake.Dto;
using ShopeeFake.Models;
using ShopeeFake.Services.Interface;
using System.Collections.Immutable;

namespace ShopeeFake.Services
{
    public class ProductService : IProductService
    {
        private readonly ShopeeFakeDbContex _context;

        public ProductService(ShopeeFakeDbContex context)
        {
            _context = context;
        }

        public async Task<ApiResult<ProductDto>> GetProducById(long productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return new ApiErrorResult<ProductDto>
                {
                    Message = "Sản phẩm với Id: " + productId + " Không tồn tại",
                    IsSuccessed = false,
                    ResultObj = null,
                };
            }
            else
            {
                var productDto = new ProductDto()
                {
                    ProductId = product.ProductId,
                    CategoryId = product.CategoryId,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    EnteredDate = DateTime.Now,
                    Image = product.Image,
                }; return new ApiSuccessResult<ProductDto>
                {
                    Message = "Đã tìm thấy sản phẩm",
                    IsSuccessed = true,
                    ResultObj = productDto
                };
            }
        }

        public async Task<IEnumerable<Product>> GetProductBySale()
        {
            return await _context.Products.Where(p => p.Sold > 0).OrderByDescending(p => p.Sold).ToListAsync();
        }

        public async Task<ApiResult<long>> CreateProduct(ProductDto productDto)
        {
            var createProduct = new Product()
            {
                ProductName = productDto.ProductName,
                CategoryId = productDto.CategoryId,
                Price = productDto.Price,
                Description = productDto.Description,
                EnteredDate = productDto.EnteredDate,
                Quantity = productDto.Quantity,
                Image = productDto.Image,
            };
            _context.Products.Add(createProduct);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<long>
            {
                Message = "Thêm Thành công sản phẩm với ID là: " + createProduct.ProductId,
                IsSuccessed = true,
                ResultObj = createProduct.ProductId
            };
        }

        public async Task<ApiResult<ProductDto>> UpdateProduct(ProductDto productDto)
        {
            var updateProduct = await _context.Products.FindAsync(productDto.ProductId);

            if (updateProduct == null)
            {
                return new ApiErrorResult<ProductDto>
                {
                    Message = "San pham can sua khong ton tai",
                    IsSuccessed = false,
                    ResultObj = null,
                };
            }
            else
            {
                updateProduct.ProductName = productDto.ProductName;
                updateProduct.Price = productDto.Price;
                updateProduct.Quantity = productDto.Quantity;
                updateProduct.EnteredDate = DateTime.Now;
                updateProduct.Description = productDto.Description;
                updateProduct.Image = productDto.Image;
                updateProduct.CategoryId = productDto.CategoryId;
            }
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<ProductDto>
            {
                Message = "Sửa thành công sản phẩm",
                IsSuccessed = true,
                ResultObj = productDto
            };
        }

        public async Task<ApiResult<long>> DeleteProduct(long productId)
        {
            var deleteProduct = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
            if (deleteProduct == null)
            {
                return new ApiErrorResult<long>
                {
                    Message = "Không tìm thấy sản phẩm cần xóa",
                    IsSuccessed = false,
                    ResultObj = productId
                };
            }
            else
            {
                _context.Products.Remove(deleteProduct);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<long>
                {
                    Message = "Xóa thành công sản phẩm",
                    IsSuccessed = true,
                    ResultObj = deleteProduct.ProductId
                };
            }
        }

        public async Task<IEnumerable<Product>> Search(string productName)
        {
            IQueryable<Product> Search = _context.Products;
            if (string.IsNullOrEmpty(productName))
            {
                return null;
            }
            else
            {
                Search = Search.Where(p => p.ProductName == productName);

                return await Search.ToListAsync();
            }
        }
    }
}