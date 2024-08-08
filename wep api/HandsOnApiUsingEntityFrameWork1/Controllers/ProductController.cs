using HandsOnApiUsingEntityFrameWork.Entities;
using HandsOnApiUsingEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEntityFrameWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpGet,Route("GetProducts")]
        public IActionResult GetAll()
        {
            var products = _productRepository.GetAll();
            return StatusCode(200, products);
        }

        [HttpGet, Route("GetProduct/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var product = _productRepository.GetProduct(id);
            if(product!=null)
            {
                return StatusCode(200,product);
            }
            else
            {
                return StatusCode(404, "Invalid Id");
            }
        }

        [HttpPost,Route("AddProduct")]
        public IActionResult Add([FromBody] Product product)
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }

        [HttpPut,Route("EditProduct")]
        public IActionResult Edit([FromBody] Product product)
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }

        [HttpDelete, Route("DeleteProduct")]
        public IActionResult Delete([FromQuery] int id)
        {
            _productRepository.Delete(id);
            return Ok();
        }
    }
}
