using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeFake.Dto;
using ShopeeFake.Models;
using ShopeeFake.Services.Interface;

namespace ShopeeFake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetProductById(long Id)
        {
            var product = await _productService.GetProducById(Id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(product);
        }

        [HttpGet("Sale")]
        public async Task<IActionResult> GetProductBySale()
        {
            var productBySale = await _productService.GetProductBySale();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(productBySale);
        }

        [HttpPost("Them")]
        public async Task<IActionResult> CreateProduct(ProductDto productDto)
        {
            var createProduct = await _productService.CreateProduct(productDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(createProduct);
            }
        }

        [HttpPut("Sua")]
        public async Task<IActionResult> UpdateProduct([FromForm] ProductDto productDto)
        {
            var updateProduct = await _productService.UpdateProduct(productDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(updateProduct);
            }
        }

        [HttpDelete("Xoa")]
        public async Task<IActionResult> DeleteProduct(long productId)
        {
            var deleteProduct = await _productService.DeleteProduct(productId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(deleteProduct);
        }

        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<Product>>> SearchProduct(string productName)
        {
            var searchResult = await _productService.Search(productName);
            return Ok(searchResult);
        }
    }
}