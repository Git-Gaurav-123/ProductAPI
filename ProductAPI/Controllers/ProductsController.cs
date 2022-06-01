
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;


using ProductAPI.Services;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]


    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var allProducts = await _productRepository.GetProductsAsync();
                return Ok(allProducts);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            
        }


       // [HttpGet("Product")]
        //public async Task<IActionResult> Product(int id)
        //{
        //    var product = await _productRepository(id);
        //    return Ok(product);
        //}
        //[HttpPost]
        //public async Task<IActionResult> ProductAsync([FromBody] Product product)
        //{
        //    try
        //    {
        //        await _productRepository.CreateAsync(product);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound();
        //    }
        //}
    }
}

